using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_project
{
    public interface IDrawingTool
    {
        string Name { get; }
        bool IsDrawing { get; }
        PenSettings PenSettings { get; set; }
        void MouseDown(Point location);
        void MouseMove(Point location);
        void MouseUp(Point location);
        void DrawPreview(Graphics g);
    }

    public abstract class BaseDrawingTool : IDrawingTool
    {
        protected Point startPoint;
        protected Point currentPoint;
        public bool IsDrawing { get; protected set; }
        public PenSettings PenSettings { get; set; }
        public abstract string Name { get; }

        public virtual void MouseDown(Point location)
        {
            startPoint = location;
            currentPoint = location;
            IsDrawing = true;
        }

        public virtual void MouseMove(Point location) => currentPoint = location;
        public virtual void MouseUp(Point location)
        {
            currentPoint = location;
            IsDrawing = false;
        }

        public abstract void DrawPreview(Graphics g);
    }
    public class BucketTool : BaseDrawingTool
    {
        public override string Name => "Bucket";

        public override void MouseDown(Point location)
        {
            if (PenSettings?.CanvasBitmap == null) return;

            FloodFill(location, PenSettings.Color);
            IsDrawing = true;
        }

        public override void MouseUp(Point location)
        {
            IsDrawing = false;
        }

        private unsafe void FloodFill(Point startPoint, Color fillColor)
        {
            var bitmap = PenSettings.CanvasBitmap;
            var targetColor = bitmap.GetPixel(startPoint.X, startPoint.Y);

            if (targetColor.ToArgb() == fillColor.ToArgb()) return;

            var q = new Queue<Point>();
            q.Enqueue(startPoint);

            var bitmapData = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb
            );

            try
            {
                int bytesPerPixel = 4;
                byte* scan0 = (byte*)bitmapData.Scan0.ToPointer();
                int stride = bitmapData.Stride;

                while (q.Count > 0)
                {
                    var pt = q.Dequeue();
                    if (!IsValidPoint(pt, bitmap)) continue;

                    byte* row = scan0 + pt.Y * stride;
                    int pixelIndex = pt.X * bytesPerPixel;

                    // Check current pixel color
                    if (row[pixelIndex + 3] != targetColor.A ||
                        row[pixelIndex + 2] != targetColor.R ||
                        row[pixelIndex + 1] != targetColor.G ||
                        row[pixelIndex] != targetColor.B) continue;

                    // Set new color
                    row[pixelIndex] = fillColor.B;     // Blue
                    row[pixelIndex + 1] = fillColor.G; // Green
                    row[pixelIndex + 2] = fillColor.R; // Red
                    row[pixelIndex + 3] = fillColor.A; // Alpha

                    // Add neighbors
                    q.Enqueue(new Point(pt.X - 1, pt.Y)); // Left
                    q.Enqueue(new Point(pt.X + 1, pt.Y)); // Right
                    q.Enqueue(new Point(pt.X, pt.Y - 1)); // Up
                    q.Enqueue(new Point(pt.X, pt.Y + 1)); // Down
                }
            }
            finally
            {
                bitmap.UnlockBits(bitmapData);
                PenSettings.CanvasBitmap = bitmap;
            }
        }

        private bool IsValidPoint(Point pt, Bitmap bmp) =>
            pt.X >= 0 && pt.X < bmp.Width && pt.Y >= 0 && pt.Y < bmp.Height;

        public override void DrawPreview(Graphics g) { }
        public override void MouseMove(Point location) { }
    }
    public class LineTool : BaseDrawingTool
    {
        public override string Name => "Line";
        public override void DrawPreview(Graphics g) =>
            g.DrawLine(PenSettings.CreatePen(), startPoint, currentPoint);
    }

    public class RectangleTool : BaseDrawingTool
    {
        public override string Name => "Rectangle";
        public override void DrawPreview(Graphics g) =>
            g.DrawRectangle(PenSettings.CreatePen(), GetRectangle());

        private Rectangle GetRectangle() =>
            new Rectangle(
                Math.Min(startPoint.X, currentPoint.X),
                Math.Min(startPoint.Y, currentPoint.Y),
                Math.Abs(currentPoint.X - startPoint.X),
                Math.Abs(currentPoint.Y - startPoint.Y));
    }
    public class EllipseTool : BaseDrawingTool
    {
        public override string Name => "Ellipse";

        public override void DrawPreview(Graphics g)
        {
            var rect = new Rectangle(
                Math.Min(startPoint.X, currentPoint.X),
                Math.Min(startPoint.Y, currentPoint.Y),
                Math.Abs(currentPoint.X - startPoint.X),
                Math.Abs(currentPoint.Y - startPoint.Y));

            g.DrawEllipse(PenSettings.CreatePen(), rect);
        }
    }
    public class FreehandTool : BaseDrawingTool
    {
        private List<Point> points = new List<Point>();

        public override string Name => "Freehand";

        private float pressure = 1f;

        public override void MouseMove(Point location)
        {
            if (!IsDrawing) return;

            // Simulate pressure based on speed
            var distance = Math.Sqrt(Math.Pow(location.X - currentPoint.X, 2) +
                          Math.Pow(location.Y - currentPoint.Y, 2));
            pressure = Math.Clamp((float)(1 - distance / 10), 0.5f, 1.5f);

            points.Add(location);
            base.MouseMove(location);
        }

        public override void MouseDown(Point location)
        {
            base.MouseDown(location);
            points.Clear();
            points.Add(location);
        }

        public override void DrawPreview(Graphics g)
        {
            if (points.Count < 2) return;

            using (var pen = new Pen(PenSettings.Color, PenSettings.Thickness * pressure))
            {
                g.DrawLines(pen, points.ToArray());
            }
        }

        public override void MouseUp(Point location)
        {
            points.Add(location);
            base.MouseUp(location);
        }
    }
    public class EraserTool : BaseDrawingTool
    {
        private List<Point> points = new List<Point>();

        public override string Name => "Eraser";

        public override void MouseDown(Point location)
        {
            base.MouseDown(location);
            points.Clear();
            points.Add(location);
        }

        public override void MouseMove(Point location)
        {
            if (!IsDrawing) return;

            points.Add(location);
            base.MouseMove(location);
        }

        public override void DrawPreview(Graphics g)
        {
            if (points.Count < 2) return;

            using (var eraser = new Pen(Color.White, PenSettings.Thickness))
            {
                g.DrawLines(eraser, points.ToArray());
            }
        }

        public override void MouseUp(Point location)
        {
            points.Add(location);
            base.MouseUp(location);
        }
    }


}
