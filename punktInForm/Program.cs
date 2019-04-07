using System;

namespace punktInForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Punkt A eingeben:");
            Point a = AssignValues.setPoint();
            Console.WriteLine("Punkt B eingeben:");
            Point b = AssignValues.setPoint();
            Console.WriteLine("Punkt C eingeben:");
            Point c = AssignValues.setPoint();
            Console.WriteLine("Punkt D eingeben:");
            Point d  = AssignValues.setPoint();
            
            Console.WriteLine("Bitte gewünschten Punkt eingeben:");
            Point e = AssignValues.setPoint();

            int func1X = Function.deltaX(a, b);
            int func1Y = Function.deltaY(a, b);

            int func2X = Function.deltaX(d, c);
            int func2Y = Function.deltaY(d, c);

            
            int valueX1 = Function.XValue(func1X,e.x);
            int valueY1 = Function.YValue(func1Y, e.y);

            int valueX2 = Function.XValue(func2X, e.x);
            int valueY2 = Function.YValue(func2Y, e.y);
            
        }
    }
}