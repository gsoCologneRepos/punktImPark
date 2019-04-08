using System;

namespace punktInForm
{
    public struct Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int p1, int p2)
        {
            X = p1;
            Y = p2;
        }
    }
}