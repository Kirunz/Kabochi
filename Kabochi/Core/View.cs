using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kabochi.Core
{
    class View
    {
        public float x, y, targetx, targety;
        public float width, height;
        public View(float x_m, float y_m, float width_m, float height_m)
        {
            targetx = x = x_m;
            targety = y = y_m;
            width = width_m;
            height = height_m;
        }

        public void move()
        {
            float difx=targetx-x, dify=targety-y;
            float distance = (float)Math.Sqrt(Math.Pow(difx, 2) + Math.Pow(dify, 2));
        }
        public void moveA()
        {
            if (targetx != x)
            {
                if (targetx - x > 5)
                    x += 5;
                else if (targetx - x < -5)
                    x -= 5;
                else
                    x = targetx;
            }
            if (targety != y)
            {
                if (targety - y > 5)
                    y += 5;
                else if (targety - y < -5)
                    y -= 5;
                else
                    y = targety;
            }
        }
    }
}
