using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Globalization;
//using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

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
            bool spoiled = false;
            int curving;


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
                int i = 0;
                int inc = 0;
                int spacing = 0;
                while (i<view.height)
                {
                    if (spoiled)
                    {
                        inc = (int)(1 + game.gameLogic.random.NextDouble() * 70);
                        spacing = (int)(game.gameLogic.random.NextDouble() * 10);
                    }
                    else
                    {
                        inc = (int)(1 + game.gameLogic.random.NextDouble() * 200);
                        spacing = (int)(game.gameLogic.random.NextDouble() * 70);
                    }
                    
                    grafx.Graphics.FillRectangle(new SolidBrush(Color.FromArgb((int)(10+game.gameLogic.random.NextDouble()*20), Color.Red)), 0, i, view.width, inc);
                    i += inc + spacing;
                }

                if (!spoiled && game.gameLogic.random.NextDouble() < 0.01)
                {
                    spoiled = true;
                    curving = (int)(game.gameLogic.random.NextDouble() * view.height);
                    
                    //inc = (int)(game.gameLogic.random.NextDouble() * view.height);
                    //grafx.Graphics.CopyFromScreen(0, inc, 0, inc + 70, new Size((int)view.width, 20));
                }
                if (spoiled)
                {
                    //Тормозит однако
                    grafx.Graphics.CopyFromScreen((int)(-10+game.gameLogic.random.NextDouble()*20), curving, 0, (int)(curving + 30 + game.gameLogic.random.NextDouble() * 40), new Size((int)view.width, 70));
                    if (game.gameLogic.random.NextDouble() < 0.01)
                        spoiled = false;
                }
                //grafx.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(120, Color.White)), 0, 0, view.width, 50);
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

                        foreach(Layer layer in game.objectManager.Layers)
                        {
                            DrawableObject obj = layer.getNextObject();
                            while (obj != null)
                            {
                                if ((obj.position.X + obj.width > view.x) && (obj.position.X < view.x + view.width) && (obj.position.Y + obj.height * 2 > view.y) && (obj.position.Y < view.y + view.height))
                                {
                                    //list.Add(obj.depth, obj);
                                    obj.Draw(grafx, (float)(obj.position.X - view.x), (float)(obj.position.Y - view.y));
                                    drawNum++;
                                }
                                obj = layer.getNextObject();
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
                int l = Cursor.Position.X;
                int s = Cursor.Position.Y;
                Stats.SetStat("lives", l);
                Stats.SetStat("scores", s);
                Stats.Draw(grafx);
            }
        }
    }
}
