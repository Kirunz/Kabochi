using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kabochi.Core
{
    class GameForm: Form
    {
        private Game game;
        public int defaultWidth;
        public int defaultHeight;
        public GameForm(Game game_m)
        {
            
            game = game_m;
            defaultWidth= this.Width = 800;
            defaultHeight= this.Height = 600;
            
            this.StartPosition = FormStartPosition.CenterScreen;
            EnableDoubleBuffer();
            Console.WriteLine("Window is created");
            game.timer = new System.Windows.Forms.Timer();
            game.timer.Interval = 10;
            game.timer.Tick += new EventHandler(game.GameFlow);
            game.timer.Start();

        }

        public void EnableDoubleBuffer()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            Console.WriteLine("Double buffer is enabled)))))))))))))))");
        }
    }
}
