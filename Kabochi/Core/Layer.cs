using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kabochi.Core
{
    class Layer
    {

            public double depth;
            private int i;
            public List<DrawableObject> objects;

            public Layer(double _depth)
            {
                objects = new List<DrawableObject>();
                depth = _depth;
                i = 0;
            }
            public DrawableObject getNextObject()
            {
                DrawableObject next = objects.ElementAtOrDefault(i);
                if (next != null)
                    i++;
                else
                    i = 0;
                return next;
            }
    }
}
