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

        private List<Layer> _Layers;

        public IList<Layer> Layers
        {
            get
            { return _Layers.AsReadOnly(); }
        }

        public IList<DrawableObject> movableObjects
        {
            get
            { return _movableObjects.AsReadOnly(); }
        }
        private List<DrawableObject> _movableObjects;

        public IList<DrawableObject> solidObjects
        {
            get
            { return _solidObjects.AsReadOnly(); }
        }
        private List<DrawableObject> _solidObjects;

        
        public Game game;
        public bool needSomeSort;

        public ObjectManager(Game game_m)
        {
            i = 0;
            needSomeSort = false;
            _gameObjects = new List<GameObject>();
            _Layers = new List<Layer>();
            _movableObjects = new List<DrawableObject>();
            _solidObjects = new List<DrawableObject>();
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
                //_drawObjects.Remove((DrawableObject)obj);
            if (obj.movable)
                _movableObjects.Remove((DrawableObject)obj);
            if (obj.solid)
                _solidObjects.Remove((DrawableObject)obj);
            _gameObjects.Remove(obj);
        }
        private Layer getLayer(double depth) //Возвращает слой с заданной глубиной. Если таких слоев нет, то создает и возвращает.
        {
            Layer a = _Layers.Find(x => x.depth == depth);
            if (a == null)
            {
                if (_Layers.Count() == 0)
                {
                    a = new Layer(depth);
                    _Layers.Add(a);
                }
                else
                {
                    int i = 0;
                    while (_Layers.Count()>i && _Layers[i].depth > depth) i++;
                    a = new Layer(depth);
                    _Layers.Insert(i, a);
                }
            }
            return a;
        }
        public void addObject(GameObject obj, double depth)
        {
            _gameObjects.Add(obj);
            if (obj.drawable)
            {
                getLayer(depth).objects.Add((DrawableObject)obj);
                //_drawObjects.Add((DrawableObject)obj);
                //_drawObjects.AddBinary(obj);
                //needSomeSort = true;
            }
            if (obj.movable)
                _movableObjects.Add((DrawableObject)obj);

            if (obj.solid)
                _solidObjects.Add((DrawableObject)obj);
         }
        //Нужно написать фабрику по динамичному добавлению любого объекта
        //public GameObject addObject(string name, float x, float y, float scale)
        //{
         //   Type type = Type.GetType(name);
        //    Object obj = new type();
        //}
        public Wall addWall(float x, float y, float scale)
        {
            Wall obj = new Wall(x, y, scale);
            addObject(obj, -1);
            return obj;
        }
        public Hero addHero(float x, float y, float scale)
        {
            Hero obj = new Hero(x, y, scale);
            addObject(obj, -10);
            return obj;
        }
        public SnowFlake addSnowFlake(float x, float y, float scale)
        {
            SnowFlake obj = new SnowFlake(x, y, scale);
            addObject(obj, -5);
            return obj;
        }
    }
}
