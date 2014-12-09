using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Globalization;
//using System.Threading;
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
            Graphics formGraphics;
            public BufferedGraphics grafx;
            BufferedGraphicsContext context;
            public View view;
            Stopwatch watch;
            double fps;
            int last;


            public DrawManager(Game game_m)
            {
                game = game_m;
                formGraphics = game.gameForm.CreateGraphics();
                game.gameForm.Resize += gameForm_Resize;
                
                Console.WriteLine(formGraphics.DpiX+"   "+formGraphics.DpiY);

                view = new View(20, 20, 1920, 1080);
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

            public void DrawFrame() //Вывод из буфера в кадр
            {
                if (watch.ElapsedMilliseconds > 1000)
                {
                    fps = (game.gameLogic.i - last);
                    last = game.gameLogic.i;
                    watch.Restart();
                }
                DrawToBuffer();
                grafx.Render();
                if (game.objectManager.needSomeSort)
                    game.objectManager.sortDrawable();

            }
            public void DrawToBuffer() //Здесь будет происходить отрисовка кадра в буфер
            {
                int drawNum = 0;
                //List<DrawableObject> list = new List<DrawableObject>();
                SortedList<int, DrawableObject> list= new SortedList<int, DrawableObject>();
                if (System.Windows.Input.Keyboard.IsKeyDown(System.Windows.Input.Key.Z) == true)
                //if (System.Windows.Input.Keyboard.GetKeyStates(System.Windows.Input.Key.Space)>0) //Отлично, для этого он просит запилить потоки и прочую чешую. Разобраться
                    grafx.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 128, 0, 0)), 0, 0, view.width, view.height);
                else
                    grafx.Graphics.FillRectangle(Brushes.Black, 0, 0,view.width, view.height);

                        foreach(DrawableObject obj in game.objectManager.drawObjects)
                        {
                                if ((obj.position.X + obj.width > view.x) && (obj.position.X < view.x + view.width) && (obj.position.Y + obj.height * 2 > view.y) && (obj.position.Y < view.y + view.height))
                                {
                                    //list.Add(obj.depth, obj);
                                    obj.Draw(grafx, (float)(obj.position.X - view.x), (float)(obj.position.Y - view.y));
                                    drawNum++;
                                }
                        };
                        /*list.Sort(delegate(DrawableObject x, DrawableObject y)
                        {
                            if (x.depth == y.depth) return 0;
                            else if (x.depth > y.depth) return -1;
                            else return 1;
                        });*/
                        for (int i = 0; i < list.Count; i++)
                        {
                            DrawableObject obj = list.ElementAt(i).Value;
                            obj.Draw(grafx, (float)(obj.position.X - view.x), (float)(obj.position.Y - view.y));
                        }
                       // foreach (DrawableObject obj in list)
                      //  {
                       //     obj.Draw(grafx, (float)(obj.position.X - view.x), (float)(obj.position.Y - view.y));
                       // }

                        grafx.Graphics.DrawString(Convert.ToString(fps), font, Brushes.Red, new Point(0, 0));
                        grafx.Graphics.DrawString(Convert.ToString(drawNum), font, Brushes.Red, new Point(0, 30));
                        grafx.Graphics.DrawLine(new Pen(Color.White,64.0f), new Point((int)-view.x, game.gameLogic.stageHeight - (int)view.y), new Point(game.gameLogic.stageWidth - (int)view.x, game.gameLogic.stageHeight - (int)view.y));
             }
        }
    }
}
