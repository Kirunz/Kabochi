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
        public void Draw(BufferedGraphics grafx, float x, float y,int frame = 0)
        {
            grafx.Graphics.DrawImage(Get(frame), x, y);
            
        }
    }
}
