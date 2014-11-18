using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;
using System.Diagnostics;

namespace Kabochi
{
    namespace Core
    {
        class DrawManager
        {
            public Game game;
            Font font;
            SolidBrush drawBrush;
            delegate void RenderFunc();
            RenderFunc RenderFunction;
            Graphics formGraphics;
            public BufferedGraphics grafx;
            BufferedGraphicsContext context;
            public View view;
            Stopwatch watch;
            double fps;
            int last;

            Graphics g;
  
            Bitmap newImage;
            void Render()
            {
                        grafx.Render(Graphics.FromHwnd(game.gameForm.Handle));
            }
            public DrawManager(Game game_m)
            {
                game = game_m;
                newImage = new Bitmap(320, 240);
                g = Graphics.FromImage(newImage);
                RenderFunction = new RenderFunc(Render);
                formGraphics = game.gameForm.CreateGraphics();
                game.gameForm.Resize += gameForm_Resize;
                
                Console.WriteLine(formGraphics.DpiX+"   "+formGraphics.DpiY);

                view = new View(20, 20, 1920, 1080);
                // Retrieves the BufferedGraphicsContext for the 
                // current application domain.
                context = BufferedGraphicsManager.Current;

                context.MaximumBuffer = new Size((int)view.width + 1, (int)view.height + 1);
                
                grafx = context.Allocate(formGraphics, new Rectangle(0, 0, game.gameForm.Width, game.gameForm.Height));
                drawBrush = new SolidBrush(Color.Black);
                font = new System.Drawing.Font("Arial", 16);
                watch = new Stopwatch();
                watch.Start();
                fps = 0.0;
                last = 0;
            }

            void gameForm_Resize(object sender, EventArgs e)
            {
                        if (grafx != null)
                        {
                            grafx.Dispose();
                            grafx = null;
                        }
                        grafx = context.Allocate(formGraphics, new Rectangle(0, 0, game.gameForm.Width, game.gameForm.Height));
                        grafx.Graphics.ResetTransform();
                        grafx.Graphics.ScaleTransform(game.gameForm.Width / view.width, game.gameForm.Height / view.height);
                        game.gameForm.Refresh();
                Console.WriteLine("Resized!" + game.gameForm.Width / view.width+" "+ game.gameForm.Height / view.height);
            }

            public void DrawFrame() //Вывод из бфра в кадр
            {
                if (watch.ElapsedMilliseconds > 1000)
                {
                    fps = (game.gameLogic.i - last);
                    last = game.gameLogic.i;
                    watch.Restart();
                }
                DrawToBuffer();
               // Render();

                game.gameForm.Invoke(RenderFunction);
            }
            public void DrawToBuffer() //Здесь будет происходить отрисовка кадра в буффере
            {
                //Console.WriteLine("s");
                //if ( game.gameLogic.i%10 < 5)
                // grafx.Graphics.Clear(Color.Orange);
                int drawNum = 0;


                /*lock (this)
                {
                    if (resizing)
                    {
                        return;
                    }
                    lock (grafx)
                    {*/
                grafx.Graphics.FillRectangle(Brushes.Black, 0, 0,view.width, view.height);
                        game.gameLogic.objects.ForEach(delegate(DrawableObject obj)
                        {
                            if ((obj.position.X + obj.width * 2 > view.x) && (obj.position.X < view.x + view.width) && (obj.position.Y + obj.height * 2 > view.y) && (obj.position.Y < view.y + view.height))
                            {
                                obj.Draw(grafx, view.x, view.y);
                                drawNum++;
                            }
                        });
                        grafx.Graphics.DrawString(Convert.ToString(fps), font, Brushes.Red, new Point(0, 0));
                        grafx.Graphics.DrawString(Convert.ToString(drawNum), font, Brushes.Red, new Point(0, 30));
                        grafx.Graphics.DrawLine(new Pen(Color.White,64.0f), new Point((int)-view.x, game.gameLogic.stageHeight - (int)view.y), new Point(game.gameLogic.stageWidth - (int)view.x, game.gameLogic.stageHeight - (int)view.y));
                    }
               // }
            //}


        }
    }
}
