using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kabochi.Core
{
    
    class ObjectManager
    {
        int i;
        public IList<GameObject> gameObjects
        {
            get
            {return _gameObjects.AsReadOnly();}
        }
        private List<GameObject> _gameObjects;
        public IList<DrawableObject> drawObjects
        {
            get { return _drawObjects.AsReadOnly(); }
        }
        private List<DrawableObject> _drawObjects;
        public Game game;
        public bool needSomeSort;

        public ObjectManager(Game game_m)
        {
            i = 0;
            needSomeSort = false;
            _gameObjects = new List<GameObject>();
            _drawObjects = new List<DrawableObject>();
            game = game_m;
        }

        public void sortDrawable(){
           // _drawObjects.Sort(delegate(DrawableObject x, DrawableObject y)
          //  {
           //     i++;
           //      if (x.depth == y.depth) return 0;
           //      else if (x.depth > y.depth) return -1;
           //      else return 1;
           //    });
             needSomeSort = false;
            Console.WriteLine(i+" sorting iterations");
        }

        public void removeObject(GameObject obj)
        {
            if (obj.drawable)
                _drawObjects.Remove((DrawableObject)obj);
            _gameObjects.Remove(obj);
        }
        public void addObject(GameObject obj)
        {
            _gameObjects.Add(obj);
            if (obj.drawable)
            {
                _drawObjects.Add((DrawableObject)obj);
                //_drawObjects.AddBinary(obj);
                //needSomeSort = true;
            }
         }
        public Hero addHero(float x, float y, float scale)
        {
            Hero obj = new Hero(x, y, scale);
            addObject(obj);
            return obj;
        }
        public SnowFlake addSnowFlake(float x, float y, float scale)
        {
            SnowFlake obj = new SnowFlake(x, y, scale);
            addObject(obj);
            return obj;
        }
    }
}
