using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteCarlo {
    public class Display {
        readonly Graphics Graphics;
        readonly int Width;
        readonly int Height;
        int Scale = 1;

        public Display(Panel panel) {
            Graphics = panel.CreateGraphics();
            Width = panel.Width;
            Height = panel.Height;
            panel.Paint += (x, y) => Clear();
        }
        /// <summary>
        /// Add point to the display.
        /// </summary>
        /// <param name="x">Value between -1.0 and 1.0</param> 
        /// <param name="y">Value between -1.0 and 1.0</param>
        /// <param name="color"></param>
        public void AddPoint(ref double x, ref double y, ref Brush color) {
            int ix = (int) (x * Width);
            int iy = (int) (y * Height);
            int xRectangle = ((Width + ix) / 2) / Scale;
            int yRectangle = ((Height + iy) / 2) / Scale;

            Graphics.FillRectangle(color, xRectangle, yRectangle, 1, 1);
        }
        public void AdjustBoard(long value) {
            Graphics.ResetTransform();

            if (value < 100L) {
                Scale = 3;
            } else if (value < 10000L) {
                Scale = 2;
            } else {
                Scale = 1;
            }
            Graphics.ScaleTransform(Scale, Scale);
        }
        public void Clear() {
            Graphics.Clear(Color.White);
            Graphics.DrawEllipse(Pens.Black, new Rectangle(0, 0, (Width - 1) / Scale, (Height - 1) / Scale));
        }
    }
}
