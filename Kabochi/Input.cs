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
        class Input
        {
            public Game game;
            public Input(Game game_m)
            {
                game = game_m;
                game.gameForm.MouseClick += gameForm_MouseClick;
                Console.WriteLine("Input module is loaded");
            }

            public void gameForm_MouseClick(object sender, MouseEventArgs e)
            {
                Console.WriteLine("Click on "+e.X+" "+e.Y);
            }
        }
    }
}
