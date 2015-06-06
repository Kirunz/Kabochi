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
        public IList<GameObject> objects;
        public IList<DrawableObject> solidObjects;
        public IList<DrawableObject> movableObjects;
        public int stageWidth;
        public int stageHeight;
        public Hero hero;
        //public List<DrawableObject> collidable;
        public GameLogic(Game game_m)
        {
            game = game_m;
            random = new Random();
            objects = game.objectManager.gameObjects;
            solidObjects = game.objectManager.solidObjects;
            movableObjects = game.objectManager.movableObjects;
            stageWidth = 3000;
            stageHeight = 3000;
            for (int i = 0; i < 1000; i++)
            {
                game.objectManager.addSnowFlake((float)(random.NextDouble() * stageWidth), (float)(random.NextDouble() * stageHeight), (float)(0.7+random.NextDouble()*2));
            }

            for (int i = 0; i < 30; i++)
            {
                game.objectManager.addWall(100, 200 + i * 32, 1);
            }
            hero = game.objectManager.addHero(300f, 400f, 5);
            
        }
        public bool Collision(DrawableObject a, DrawableObject b) //Обрабатывает последствия столкновения
        {
            return (Math.Abs(a.position.X - b.position.X) < (a.width / 2 + b.width / 2) &&
                        Math.Abs(a.position.Y - b.position.Y) < (a.height / 2 + b.height / 2)); //correct collision with && is boooring

            //!(this.position.Y < (b.position.Y + b.height) ||
            //    (this.position.Y + this.height) > b.position.Y ||
            //    (this.position.X + this.width) < b.position.X ||
            //    this.position.X > (b.position.X + b.width));
        }

        public void GameStep()
        {
            game.inputManager.gameStep();
            game.drawManager.view.x = (float)hero.position.X - game.gameForm.Width / 2;
            game.drawManager.view.y = (float)hero.position.Y - game.gameForm.Height / 2;
               // SnowFlake a = game.objectManager.addSnowFlake(game.drawManager.view.x + , game.drawManager.view.y + e.Y , (float)(5+game.gameLogic.random.NextDouble()*12));
            //objects.Sort(delegate(GameObject x, GameObject y)
             //   {   
                    //Из-за подобной проверки типов отжирается солидный кусок производительности (падение с 65 до 45 фпс при 10к объектов)
                                                                                                 // Через GetType - до 40
                    //Так что нужно это сделать красивее
                    //if (!(typeof(DrawableObject).IsInstanceOfType(x)) && !(typeof(DrawableObject).IsInstanceOfType(y))) return 0;
                    //else if (x.GetType().GetProperty("depth") == null) return 1; 
                    //else if (y.GetType().GetProperty("depth") == null) return -1;
                    //else if (!(typeof(DrawableObject).IsInstanceOfType(x))) return 1;
                    //else if (!(typeof(DrawableObject).IsInstanceOfType(y))) return -1;
                 //       DrawableObject dx = (DrawableObject) x;
                 //       DrawableObject dy = (DrawableObject) y;
                 //   if (dx.depth == dy.depth) return 0;
                 //   else if (dx.depth > dy.depth) return -1;
                 //   else return 1;
               // });
            //System.Windows.Forms.Cursor.Position = new System.Drawing.Point(game.gameForm.Width/2, game.gameForm.Height/2);
            i++;
            
            game.drawManager.view.moveA();
            //Проверка столкновений
            foreach (DrawableObject obj in movableObjects)
            {
                foreach (DrawableObject obj2 in solidObjects)
                    if (this.Collision(obj, obj2) && obj2!=obj)
                        obj.CollisionWith(obj2);
            }
            foreach (GameObject obj in objects) //Вот это нужно оптимизировать
            {
                obj.Update(this);
            }
        }
    }
}
