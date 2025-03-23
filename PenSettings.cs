using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_project
{
    public class PenSettings
    {
        public Bitmap CanvasBitmap { get; set; }
        private Color color = Color.Black;
        private int thickness = 2;
      

        public Color Color
        {
            get => color;
            set
            {
                color = value;
                ColorChanged?.Invoke();
            }
        }

        public int Thickness
        {
            get => thickness;
            set
            {
                thickness = value;
                ThicknessChanged?.Invoke();
            }
        }

        public event Action ColorChanged;
        public event Action ThicknessChanged;

        public Pen CreatePen() => new Pen(Color, Thickness);
    }
}
