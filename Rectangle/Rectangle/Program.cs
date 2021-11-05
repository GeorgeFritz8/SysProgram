using System;

namespace Rectangle
{
    class Rectangle
    {
        public double width;
        public double height;

        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }

        public double perimeter()
        {
            return 2 * (width + height);
        }
        public double area()
        {
            return width * height;
        }
        public bool isSquare()
        {
            if (width == height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

//      public class Player
