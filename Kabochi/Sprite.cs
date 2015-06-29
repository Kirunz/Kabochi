using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kabochi
{
    class Sprite : DrawableObject
    {
        protected Dictionary<int, Bitmap> ImgArr;
        public Sprite(Dictionary<int, Bitmap> imageArray)
        {
            ImgArr = imageArray;
        }
        public Bitmap Get(int frame = 0)
        {
            if (ImgArr.ContainsKey(frame))
            {
                return ImgArr[frame];
            }
            else
            {
                return ImgArr[0];
            }
        }

        public Bitmap Rotate(int degree,int frame)
        {
            switch (degree)
            {
                case 90:
                    Get(frame).RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case 180:
                    Get(frame).RotateFlip(RotateFlipType.Rotate180FlipNone);
                    break;
                case 270:
                    Get(frame).RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;
            }
            return Get(frame);
        }
        public void Draw(BufferedGraphics grafx, float x, float y,int frame = 0, int degree = 0)
        {
            if (degree > 0)
                Rotate(degree, frame);
            grafx.Graphics.DrawImage(Get(frame), x, y);
            
        }
    }
}
