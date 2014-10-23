using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kabochi.Core
{
    class GameLogic
    {
        private Game game;
        public int i=0;
        public GameLogic(Game game_m)
        {
            game = game_m;
        }

        public void GameStep()
        {
            i++;
        }
    }
}
