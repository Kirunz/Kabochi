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
        public Random random;
        public List<DrawableObject> objects;
        public int stageWidth;
        public int stageHeight;
        public GameLogic(Game game_m)
        {
            game = game_m;
            random = new Random();
            objects = new List<DrawableObject>();
            stageWidth = 3000;
            stageHeight = 3000;
            for (int i = 0; i < 5000; i++)
            {
                objects.Add(new DrawableObject("face2.png", (float)random.NextDouble() * stageWidth, (float)random.NextDouble() * stageHeight, (float)(0.2+random.NextDouble()*2)));
            }
            
        }

        public void GameStep()
        {
            //System.Windows.Forms.Cursor.Position = new System.Drawing.Point(game.gameForm.Width/2, game.gameForm.Height/2);
            i++;
            game.drawManager.view.moveA();
            objects.ForEach(delegate(DrawableObject obj)
            {
                obj.MoveVector();
               if (random.NextDouble() < 0.01)
               {
                   //obj.vector=System.Windows.Vector.Add(obj.vector, System.Windows.)
                   obj.angle = 230+(float)random.NextDouble() * 80;
                   obj.speed = (float)0.1 + (float)random.NextDouble() * 1;
                  //obj.moveTo((float)random.NextDouble() * (stageWidth - obj.image.Width), (float)random.NextDouble() * (stageHeight - obj.image.Height));
               }
            });
        }
    }
}
