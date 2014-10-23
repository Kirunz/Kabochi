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
            public InputManager(Game game_m)
            {
                game = game_m;
                game.gameForm.MouseClick += gameForm_MouseClick; //Слушаем клики мышью
                game.gameForm.KeyDown += gameForm_KeyDown;
                game.gameForm.MouseMove += gameForm_MouseMove;
                Console.WriteLine("Input module is loaded");
            }

            void gameForm_MouseMove(object sender, MouseEventArgs e)
            {

                //throw new NotImplementedException();
            }

            void gameForm_KeyDown(object sender, KeyEventArgs e)
            {
                Console.WriteLine(e.KeyData);
                //throw new NotImplementedException();
            }

            void gameForm_MouseClick(object sender, MouseEventArgs e)
            {
                
                Console.WriteLine("Click on "+e.X+" "+e.Y);
            }
        }
    }
}
