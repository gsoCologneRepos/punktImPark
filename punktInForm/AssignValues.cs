using System;

namespace punktInForm
{
    public class AssignValues
    {

        public static Point SetPoint()
        {
            int x, y;

            Console.Write("X-Wert: ");
            while(!int.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("X-Wert: ");
            }

            Console.Write("Y-Wert: ");
            while(!int.TryParse(Console.ReadLine(), out y))
            {
                Console.Write("Y-Wert: ");
            }
            
            var point = new Point(x,y);
            return point;
        }
    }
}