using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kabochi.Core
{
    
    class ObjectManager
    {
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
            needSomeSort = false;
            _gameObjects = new List<GameObject>();
            _drawObjects = new List<DrawableObject>();
            game = game_m;
        }

        public void sortDrawable(){
            _drawObjects.Sort(delegate(DrawableObject x, DrawableObject y)
            {   
                 if (x.depth == y.depth) return 0;
                 else if (x.depth > y.depth) return -1;
                 else return 1;
               });
            needSomeSort = false;
        }
        public SnowFlake addSnowFlake(float x, float y, float scale)
        {
            SnowFlake obj = new SnowFlake(x, y, scale);
            _gameObjects.Add(obj);
            if (obj.drawable)
            {
                _drawObjects.Add(obj);
                needSomeSort = true;
            }
            return obj;
        }
    }
}
