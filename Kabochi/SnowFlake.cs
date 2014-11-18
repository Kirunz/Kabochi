using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;

namespace Kabochi
{
    class SnowFlake: DrawableObject
    {
        public Brush brush;
        public SnowFlake(float x_m, float y_m, float scale_m)
        {
            depth = 0;
            _angle = 270;
            _speed = 1.2f;
            CalculateVector();
            position = new System.Windows.Point(x_m, y_m);
            width = height = scale_m * 5;
            brush = Brushes.Azure;
        }
        override public void Draw(BufferedGraphics grafx, float viewX, float viewY)
        {
            grafx.Graphics.FillEllipse(brush, (float)(position.X - viewX), (float)(position.Y - viewY), width, height);
        }
    }
}
