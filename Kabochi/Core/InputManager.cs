using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Kabochi
{
    namespace Core
    {
        class InputManager
        {
            public Game game;
            public Point oldPosition = Cursor.Position;
            bool middleButtonIsPressed = false;
            public InputManager(Game game_m)
            {
                oldPosition = Cursor.Position;
                game = game_m;
                game.gameForm.MouseClick += gameForm_MouseClick; //Слушаем клики мышью
                game.gameForm.MouseDown += gameForm_MouseDown;
                game.gameForm.MouseUp += gameForm_MouseUp;
                game.gameForm.KeyDown += gameForm_KeyDown;
                game.gameForm.MouseMove += gameForm_MouseMove;
                Console.WriteLine("Input module is loaded");
            }


            void gameForm_MouseUp(object sender, MouseEventArgs e)
            {
             
                
                if (e.Button == MouseButtons.Middle)
                { 
                    middleButtonIsPressed = false;
                }
                //middleButtonIsPressed = (!(e.Button == MouseButtons.Middle) || middleButtonIsPressed);
            }

            void gameForm_MouseDown(object sender, MouseEventArgs e)
            {
                
                if (e.Button == MouseButtons.Middle)
                {
                    middleButtonIsPressed = true;
                    oldPosition = Cursor.Position;
                }
                    
            }

            public void gameForm_MouseMove(object sender, MouseEventArgs e)
            {
                //throw new NotImplementedException();
                if (middleButtonIsPressed)
                { 
                game.drawManager.view.x -= Cursor.Position.X - oldPosition.X;
                game.drawManager.view.y -= Cursor.Position.Y - oldPosition.Y;
                game.drawManager.view.targetx = game.drawManager.view.x;
                game.drawManager.view.targety = game.drawManager.view.y;
                //System.Windows.Point;
                //Cursor.Position = oldPosition;
                oldPosition = Cursor.Position;
                }
            }

            public void gameForm_KeyDown(object sender, KeyEventArgs e)
            {
                Console.WriteLine(e.KeyData);
                switch (e.KeyData)
                {
                    case Keys.Escape:
                        Application.Exit();
                        break;
                    case Keys.A:
                        lock (game.drawManager.grafx)
                        {
                            game.drawManager.grafx.Graphics.ScaleTransform(1.1f, 1.1f);
                        }
                        break;
                    case Keys.S:
                        lock (game.drawManager.grafx)
                        {
                            game.drawManager.grafx.Graphics.ScaleTransform(0.9f, 0.9f);
                            
                        }
                        break;
                    case Keys.R:
                        lock (game.drawManager.grafx)
                        {
                            game.drawManager.grafx.Graphics.ResetTransform();

                        }
                        break;
                    case Keys.Left:
                        lock (game.drawManager.grafx)
                        {
                            //game.drawManager.grafx.Graphics.TranslateTransform(-5, 0);
                            game.drawManager.view.targetx -= 5;
                        }
                        break;
                    case Keys.Right:
                        lock (game.drawManager.grafx)
                        {
                            //game.drawManager.grafx.Graphics.TranslateTransform(5,0);
                            game.drawManager.view.targetx += 5;
                        }
                        break;
                    case Keys.Up:
                        lock (game.drawManager.grafx)
                        {
                            //game.drawManager.grafx.Graphics.TranslateTransform(0, -5);
                            game.drawManager.view.targety -= 5;
                        }
                        break;
                    case Keys.Down:
                        lock (game.drawManager.grafx)
                        {
                            //game.drawManager.grafx.Graphics.TranslateTransform(0, 5);
                            game.drawManager.view.targety += 5;
                        }
                        break;
                    default:
                        break;
                }
                //throw new NotImplementedException();
            }

            public void gameStep()
            {
                if (System.Windows.Input.Keyboard.IsKeyDown(System.Windows.Input.Key.Z) == true)
                {
                    float size = (float)(5 + game.gameLogic.random.NextDouble() * 12);
                    game.objectManager.addSnowFlake(game.drawManager.view.x + Cursor.Position.X - (float)(size *2.5), game.drawManager.view.y + Cursor.Position.Y - (float)(size *2.5), size);
                }
            }
            public void gameForm_MouseClick(object sender, MouseEventArgs e)
            {
                if (e.Button==MouseButtons.Left)
                {
                    SnowFlake a = game.objectManager.addSnowFlake(game.drawManager.view.x + e.X, game.drawManager.view.y + e.Y , (float)(5+game.gameLogic.random.NextDouble()*12));
                    a.brush = Brushes.Green;
                    a.depth = 10;
                    //game.gameLogic.objects.Add(a);
                }
                //if (e.Button == MouseButtons.Right && !middleButtonIsPressed)
                //{
                //    game.drawManager.view.targetx = game.drawManager.view.x + e.X -game.gameForm.Width / 2;
                //    game.drawManager.view.targety = game.drawManager.view.y + e.Y - game.gameForm.Height / 2;
                //    Console.WriteLine("View is on " + game.drawManager.view.x + " " + game.drawManager.view.y);
                //}
                if (e.Button == MouseButtons.Right)
                {
                    SnowFlake a = game.objectManager.addSnowFlake(game.drawManager.view.x + e.X, game.drawManager.view.y + e.Y, (float)(5 + game.gameLogic.random.NextDouble() * 12));
                    a.brush = Brushes.Red;
                    a.depth = -10;
                    //game.gameLogic.objects.Add(a);
                }
                Console.WriteLine(e.Button+" click on "+e.X+" "+e.Y);
            }
        }
    }
}
