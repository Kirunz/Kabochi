using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;

namespace Kabochi
{
    class Wall: DrawableObject
    {
        
        Brush brush;
        public  Wall(float x_m, float y_m, float scale_m)
        {
            drawable = true;
            solid = true;
            width = height = scale_m * 32;
            position = new System.Windows.Point(x_m, y_m);
            brush = Brushes.Red;
        }
        public override void Draw(BufferedGraphics grafx, float x, float y)
        {
            grafx.Graphics.FillRectangle(this.brush, x, y, width, height);
        }
    }
}
