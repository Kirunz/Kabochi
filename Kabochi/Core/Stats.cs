using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Kabochi.Core
{
    class Stats
    {
        static string lives;
        static string scores;
        static public void Draw(BufferedGraphics graphx)
        {
            Font font = new System.Drawing.Font("Comic Sans MS", 16);
            graphx.Graphics.DrawString("Lives: " + lives, font, Brushes.Green, new Point(50, 0));
            graphx.Graphics.DrawString("Scores: " + scores, font, Brushes.Green, new Point(50, 30));
        }
        static public void SetStat(string name, int value)
        {
            if (name == "lives")
                lives = Convert.ToString(value);
            if (name == "scores")
                scores = Convert.ToString(value);
        }
    }
}
