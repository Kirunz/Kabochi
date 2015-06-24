using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Kabochi.Core
{
    class SpriteManager
    {
        private string path = "C:/Users/1/Desktop/";
        private Dictionary<string, Sprite> spriteArr = new Dictionary<string, Sprite>();

        public Bitmap FromFile(string fileName)
        {
            return new Bitmap(path + fileName);
        }

        public void SetSprite(string fileName, Dictionary<int, Bitmap> images)
        {
            spriteArr.Add(fileName, new Sprite(images));
        }

        public Sprite GetSprite(string fileName)
        {
            if (spriteArr.ContainsKey(fileName))
            {
                return spriteArr[fileName];
            }
            else
            {
                var images = new Dictionary<int, Bitmap>()
                {
                    {0, FromFile(fileName)}
                };
                SetSprite(fileName,images);
                return spriteArr[fileName];
            }
            
        }
        public void SetFrames(string fileName, int rowFrames, int columnFrames)
        {
            Bitmap currentBitmap = FromFile(fileName); 
            int height = currentBitmap.Height / rowFrames;
            int width = currentBitmap.Width / columnFrames;
            var images = new Dictionary<int, Bitmap>();

            for (int i = 0; i < rowFrames; i++)
            {
                for (int j = 0; j < columnFrames; j++)
                {
                    images.Add(i * columnFrames + j, currentBitmap.Clone(new Rectangle(width * j, height * i, width, height), currentBitmap.PixelFormat));        
                }
            }
            SetSprite(fileName,images);      
        }

    }
}
