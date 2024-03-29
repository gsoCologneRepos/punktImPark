using System;

namespace punktInForm
{
    public class Function
    {
        public static double deltaX(Point a, Point b)
        {
            return b.X - a.X;
        }
        
        public static double deltaY(Point a, Point b)
        {
            return b.Y - a.Y;
        }

        public static double XValue(double deltaX, double deltaY)
        {
            return deltaY / deltaX;
        }
        
        public static double YValue(Point a, double xValue)
        {
            double y = 0;
            for(int i = 0; i<=a.X;i++)
            {
                y = a.Y - xValue;
            }

            return y;
        }
    }
}