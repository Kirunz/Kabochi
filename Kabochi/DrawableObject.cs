using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;

namespace Kabochi
{
    class DrawableObject
    {
        //public Bitmap image;
        private float scale, _angle, _speed;
        public System.Windows.Point position;
        public float angle
        {
            get
            {
                return _angle;
            }
            set
            {
                _angle = value;
                CalculateVector();

            }
        }
        public float speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
                CalculateVector();

            }
        }
        public PseudoImage image;
        public Vector vector;
        public class PseudoImage{
            public float Width, Height;
        }

        public DrawableObject(string imagePass, float x_m, float y_m, float scale_m)
        {
            //Image promtImage = Image.FromFile(imagePass);
            //image = promtImage;
            //image = new Bitmap(promtImage, new Size((int)(promtImage.Width*scale_m),(int)(promtImage.Height*scale_m)));
            image = new PseudoImage();
            _angle = 270;
            _speed = 1.2f;
            CalculateVector();
            position = new System.Windows.Point(x_m, y_m);
            scale = scale_m;
            image.Width = image.Height = 5 * scale_m;
            //Console.WriteLine("Created at [" + x + "; " + y + "] with size "+image.Width+"*"+image.Height);
        }

        private void CalculateVector()
        {
            vector = Vector.Multiply(new Vector(Math.Cos(angle * Math.PI / 180), -Math.Sin(angle * Math.PI / 180)), speed);
        }
        public void MoveTo(float x_m, float y_m)
        {
            position = new System.Windows.Point(x_m, y_m);
        }
        public void MoveVector()
        {
            position = Vector.Add(vector, position);
        }
    }
}
