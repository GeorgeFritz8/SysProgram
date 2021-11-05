using System;

namespace DebuggingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[10];

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point() { x = i, y = 0 };
            }
            string msg = null;

            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine($"from {i} to {i + 1} the distance is:");
                int dist = CalcDist(points[i].x, points[i].y);
                Console.WriteLine(dist);
                if (dist == 1)
                {
                    msg = $"{i} and {i + 1} are next to eachother";
                }
            }

            Console.WriteLine(msg.ToLower());
            Console.ReadLine();
        }

        private static int CalcDist(int from, int to)
        {
            int result = from - to;

            return result;
        }

        class Point
        {
            public int x, y;
        }

    }
}
