using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args) {
            Rectangle rectangle = new Rectangle(100, 100, 50, 60);
            Rectangle square = new Rectangle(50, 50, 50, 50);
            Rectangle squareMove = new Rectangle(50, 50, 50, 50);
            Rectangle rectanglemove = new Rectangle(100, 100, 20, 30);
        }
    }

    class Rectangle
    {
        private bool _isSquare;
        private float x, y, width, height;

        public Rectangle(float x, float y, float width, float height) {
            if(width == height) {
                _isSquare = true;
            }
            Set(x, y, width, height);
        }
        public void MoveTo(float x, float y) {
            this.x = x;
            this.y = y;
        }
        public bool isSquare() {
            return _isSquare;
        }
        public void Set(float x, float y, float width, float height) {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            if (_isSquare) {
                Console.WriteLine($"Made new square at {x} {y} with {width} width, height {height}");
            } else {
                Console.WriteLine($"Made new rectangle at {x} {y} with {width} width, height {height}");
            }
        }
    }
}
