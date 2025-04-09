using System.Drawing.Imaging;
using System.Windows.Forms;

namespace midterm_project
{
    public partial class MainForm : Form
    {
        private Bitmap canvasBitmap;
        private Graphics canvasGraphics;
        private Stack<Image> undoStack = new Stack<Image>();
        private Stack<Image> redoStack = new Stack<Image>();
        private IDrawingTool currentTool;
        private PenSettings penSettings = new PenSettings();

        public MainForm()
        {
            InitializeComponent();
            InitializeCanvas();
            SetKeyboardShortcuts();
            SelectTool(new FreehandTool());
        }

        private void InitializeCanvas()
        {
            canvasBitmap = new Bitmap(picCanvas.Width, picCanvas.Height, PixelFormat.Format32bppArgb);
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.Clear(Color.White);
            picCanvas.Image = canvasBitmap;

            // Update pen settings with current bitmap
            penSettings.CanvasBitmap = canvasBitmap;

        }

        private void SetKeyboardShortcuts()
        {
            KeyPreview = true;
            KeyDown += (s, e) =>
            {
                if (e.Control && e.KeyCode == Keys.Z) Undo();
                if (e.Control && e.KeyCode == Keys.Y) Redo();
                if (e.Control && e.KeyCode == Keys.N) ClearCanvas();
            };
        }

        // Tool selection handlers
        private void SelectTool(IDrawingTool tool)
        {
            currentTool = tool;
            currentTool.PenSettings = penSettings;


            // Ensure fresh state for bucket tool
            if (tool is BucketTool)
            {
                penSettings.CanvasBitmap = canvasBitmap;
                picCanvas.Refresh();
            }

            UpdateToolStatus();
        }

        private void btnLine_Click(object sender, EventArgs e) => SelectTool(new LineTool());
        private void btnRectangle_Click(object sender, EventArgs e) => SelectTool(new RectangleTool());
        private void btnEllipse_Click(object sender, EventArgs e) => SelectTool(new EllipseTool());
        private void btnEraser_Click(object sender, EventArgs e) => SelectTool(new EraserTool());
        private void btnUndo_Click(object sender, EventArgs e) => Undo();
        private void btnRedo_Click(object sender, EventArgs e) => Redo();
        private void btnFreehand_Click(object sender, EventArgs e) => SelectTool(new FreehandTool());
        private void btnClearCanvas_Click(object sender, EventArgs e) => ClearCanvas();
        private void btnBucket_Click(object sender, EventArgs e) => SelectTool(new BucketTool());

        // Canvas mouse handlers
        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            currentTool?.MouseDown(e.Location);

            // Immediate redraw after mouse down for bucket tool
            if (currentTool is BucketTool)
            {
                picCanvas.Invalidate();
                SaveState();
            }
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentTool?.IsDrawing != true) return;

            // For freehand drawing, we need to continuously update
            if (currentTool is FreehandTool)
            {
                currentTool.MouseMove(e.Location);
                picCanvas.Invalidate();

                // Immediate draw for smoother experience
                using (var g = Graphics.FromImage(canvasBitmap))
                {
                    currentTool.DrawPreview(g);
                }
            }
            else
            {
                currentTool.MouseMove(e.Location);
                picCanvas.Invalidate();
            }
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentTool?.IsDrawing != true) return;

            if (!(currentTool is FreehandTool))
            {
                currentTool.DrawPreview(canvasGraphics);
            }

            currentTool.MouseUp(e.Location);
            SaveState();
            picCanvas.Invalidate(); // Force redraw after operation
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (currentTool?.IsDrawing == true)
            {
                currentTool.DrawPreview(e.Graphics);
            }
        }

        private void SaveState()
        {
            undoStack.Push((Image)canvasBitmap.Clone());
            redoStack.Clear();
        }

        public void Undo()
        {
            if (undoStack.Count > 1)
            {
                redoStack.Push(undoStack.Pop());
                canvasBitmap = (Bitmap)undoStack.Peek().Clone();
                canvasGraphics = Graphics.FromImage(canvasBitmap);
                picCanvas.Image = canvasBitmap;
            }
        }

        public void Redo()
        {
            if (redoStack.Count > 0)
            {
                var state = redoStack.Pop();
                undoStack.Push(state);
                canvasBitmap = (Bitmap)state.Clone();
                canvasGraphics = Graphics.FromImage(canvasBitmap);
                picCanvas.Image = canvasBitmap;
            }
        }

        private void ClearCanvas()
        {
            SaveState();
            canvasGraphics.Clear(Color.White);
            picCanvas.Invalidate();
        }

        private void UpdateToolStatus() => lblTool.Text = currentTool?.Name ?? "None";

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                penSettings.Color = colorDialog.Color;
            }
        }

        private void numThickness_ValueChanged(object sender, EventArgs e)
        {
            penSettings.Thickness = (int)numThickness.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    var format = Path.GetExtension(saveDialog.FileName) == ".png"
                        ? ImageFormat.Png : ImageFormat.Jpeg;

                    canvasBitmap.Save(saveDialog.FileName, format);
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

