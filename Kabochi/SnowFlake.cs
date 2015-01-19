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
            drawable = true;
            depth = 0;
            _angle = 270;
            _speed = 1.2f;
            CalculateVector();
            position = new System.Windows.Point(x_m, y_m);
            width = height = scale_m * 5;
            brush = Brushes.Azure;
        }
        override public void Draw(BufferedGraphics grafx, float x, float y)
        {
            grafx.Graphics.FillEllipse(brush, x, y, width, height);

        }

        override public void Update(Core.GameLogic gameLogic)
        {
            if (position.Y > gameLogic.stageHeight)
                position.Y = 0;
            MoveVector();
            if (gameLogic.random.NextDouble() < 0.01)
            {
                //obj.vector=System.Windows.Vector.Add(obj.vector, System.Windows.)
                angle = 230 + (float)gameLogic.random.NextDouble() * 80;
                speed = 0.4f + (float)gameLogic.random.NextDouble() * 0.8f;
                //obj.moveTo((float)random.NextDouble() * (stageWidth - obj.image.Width), (float)random.NextDouble() * (stageHeight - obj.image.Height));
            }
        }
    }
}
