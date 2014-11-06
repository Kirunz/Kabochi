using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Kabochi
{
    class DrawableObject
    {
        //public Bitmap image;
        public float x, y, speed, angle, scale;
        public PseudoImage image;
        public class PseudoImage{
            public float Width, Height;
        }

        public DrawableObject(string imagePass, float x_m, float y_m, float scale_m)
        {
            //Image promtImage = Image.FromFile(imagePass);
            //image = promtImage;
            //image = new Bitmap(promtImage, new Size((int)(promtImage.Width*scale_m),(int)(promtImage.Height*scale_m)));
            image = new PseudoImage();
            angle = 15;
            speed = 2;
            x = x_m;
            y = y_m;
            scale = scale_m;
            image.Width = image.Height = 100 * scale_m;
            //Console.WriteLine("Created at [" + x + "; " + y + "] with size "+image.Width+"*"+image.Height);
        }
        public void moveTo(float x_m, float y_m)
        {
            x = x_m;
            y = y_m;
        }
        public void MoveDirection()
        {
            x += (float)Math.Cos(angle * Math.PI / 180);
            y -= (float)Math.Sin(angle * Math.PI / 180);
        }
    }
}
