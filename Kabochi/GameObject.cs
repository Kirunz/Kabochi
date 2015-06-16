using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kabochi
{
    class GameObject
    {
        public bool drawable=false;
        public bool collidable = false;
        public bool movable = false;
        public bool solid = false;
        public GameObject()
        {
        }

        virtual public void Update(Core.GameLogic gameLogic)
        {
        }
    }
}
