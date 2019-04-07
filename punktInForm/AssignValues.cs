using System;

namespace punktInForm
{
    public class AssignValues
    {

        public static Point setPoint()
        {
            int x, y;
            Console.WriteLine("X Wert:");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Y Wert:");
            y = Int32.Parse(Console.ReadLine());
            Point a = new Point(x,y);
            return a;
        }
    }
}