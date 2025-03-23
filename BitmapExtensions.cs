using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_project
{
    public static class BitmapExtensions
    {
        public static void LockBits(this Bitmap bitmap)
        {
            bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadWrite,
                bitmap.PixelFormat
            );
        }

        public static void UnlockBits(this Bitmap bitmap)
        {
            bitmap.UnlockBits();
        }

        public static unsafe Color GetPixel(this Bitmap bitmap, int x, int y)
        {

            var data = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadOnly,
                bitmap.PixelFormat
            );

            try
            {
                byte* scan0 = (byte*)data.Scan0;
                int stride = data.Stride;

                // For 32bppArgb format
                byte* p = scan0 + y * stride + x * 4;
                return Color.FromArgb(p[3], p[2], p[1], p[0]);
            }
            finally
            {
                bitmap.UnlockBits(data);
            }
        }

        public static unsafe void SetPixel(this Bitmap bitmap, int x, int y, Color color)
        {
            var data = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.WriteOnly,
                bitmap.PixelFormat
            );

            try
            {
                byte* scan0 = (byte*)data.Scan0;
                int stride = data.Stride;

                // For 32bppArgb format
                byte* p = scan0 + y * stride + x * 4;
                p[0] = color.B;
                p[1] = color.G;
                p[2] = color.R;
                p[3] = color.A;
            }
            finally
            {
                bitmap.UnlockBits(data);
            }
        }
    }
}
