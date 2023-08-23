using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Liskov_Substitution
{
    public abstract class Shape
    {
        protected int height;
        protected int width;

        public abstract int GetArea();
    }

    public class Rect : Shape
    {
        public void SetHeight(int _height)
        {
            height = _height;
        }

        public void SetWidth(int _width)
        {
            width = _width;
        }

        public override int GetArea()
        {
            return height * width;
        }
    }

    public class Square : Shape
    {
        public void SetSide(int side)
        {
            height = side;
            width = side;
        }

        public override int GetArea()
        {
            return height * width;
        }
    }
}
