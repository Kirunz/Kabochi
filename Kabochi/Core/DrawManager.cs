using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;

namespace Kabochi
{
    namespace Core
    {
        class DrawManager
        {
            public Game game;
            Font font;
            SolidBrush drawBrush;
            Graphics formGraphics;
  
            Image newImage = Image.FromFile("face2.png");
            public DrawManager(Game game_m)
            {
                game = game_m;

                formGraphics = game.gameForm.CreateGraphics();
                game.gameForm.Resize += gameForm_Resize;
                
                Console.WriteLine(formGraphics.DpiX+"   "+formGraphics.DpiY);
                formGraphics.ScaleTransform(game.gameForm.Width / 320, game.gameForm.Height / 240);
                // Retrieves the BufferedGraphicsContext for the 
                // current application domain.
                //context = BufferedGraphicsManager.Current;

                // Sets the maximum size for the primary graphics buffer
                // of the buffered graphics context for the application
                // domain.  Any allocation requests for a buffer larger 
                // than this will create a temporary buffered graphics 
                // context to host the graphics buffer.
                //context.MaximumBuffer = new Size(game.gameForm.Width + 1, game.gameForm.Height + 1);
                //formGraphics = context.Allocate(game.gameForm.CreateGraphics(), new Rectangle(0, 0, game.gameForm.Width, game.gameForm.Height));

                drawBrush = new SolidBrush(Color.Black);
                font = new System.Drawing.Font("Arial", 16);
            }

            void gameForm_Resize(object sender, EventArgs e)
            {
                //formGraphics = game.gameForm.CreateGraphics();
                //formGraphics.ScaleTransform(game.gameForm.Width / 640, game.gameForm.Height / 480);
                formGraphics.ScaleTransform(game.gameForm.Width / 320, game.gameForm.Height / 240);
                Console.WriteLine(game.gameForm.Width + "   " + game.gameForm.Height);
            }

            public void DrawFrame() //Здесь будет происходить отрисовка кадра
            {                      // По хорошему здесь просто пихаем изображение из буфера на канвас. А само изображение буфера генерируется ранее
                //Console.WriteLine("s");
                if ( game.gameLogic.i%10 < 5)
                formGraphics.Clear(Color.Orange);
                else
                formGraphics.Clear(Color.Black);
                formGraphics.DrawString(Convert.ToString(game.gameLogic.i), font, drawBrush, new Point(0, 0));
                formGraphics.DrawImage(newImage, new Point(Convert.ToInt32(30+25*Math.Sin(game.gameLogic.i/30.0)), 30));
                //formGraphics.Render(game.gameForm.);
            }


        }
    }
}
