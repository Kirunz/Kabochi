using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;

namespace Kabochi
{
    class DrawableObject : GameObject
    {
        //public Bitmap image;
        protected float _angle, _speed;

        public int depth;
        public float width, height;
        public System.Windows.Point position;
        public float angle
        {
            get
            {
                return _angle;
            }
            set
            {
                _angle = value;
                CalculateVector();

            }
        }
        public float speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
                CalculateVector();

            }
        }
        public Vector vector;

        public DrawableObject()
        {

        }
        public DrawableObject(string imagePass, float x_m, float y_m, float scale_m)
        {
            drawable = true;
            depth = 0;
            CalculateVector();
            position = new System.Windows.Point(x_m, y_m);
            width = height = scale_m;
        }

        public bool CollidesWith(DrawableObject b)
        {
            return  (   Math.Abs(this.position.X-b.position.X)<(this.width/2+b.width/2) ||
                        Math.Abs(this.position.Y - b.position.Y) < (this.height / 2 + b.height / 2)); //correct collision with && is boooring
                
                //!(this.position.Y < (b.position.Y + b.height) ||
                //    (this.position.Y + this.height) > b.position.Y ||
                //    (this.position.X + this.width) < b.position.X ||
                //    this.position.X > (b.position.X + b.width));
        }
        protected void CalculateVector()
        {
            vector = Vector.Multiply(new Vector(Math.Cos(angle * Math.PI / 180), -Math.Sin(angle * Math.PI / 180)), speed);
        }
        public void MoveTo(float x_m, float y_m)
        {
            position = new System.Windows.Point(x_m, y_m);
        }
        public void MoveVector()
        {
            position = Vector.Add(vector, position);
        }

        virtual public void Draw(BufferedGraphics grafx, float x, float y){}
    }
}
