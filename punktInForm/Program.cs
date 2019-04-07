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
            /*Console.WriteLine("Punkt C eingeben:");
            Point c = AssignValues.setPoint();
            Console.WriteLine("Punkt D eingeben:");
            Point d  = AssignValues.setPoint();*/
            
            Console.WriteLine("Bitte gewünschten Punkt eingeben:");
            Point e = AssignValues.setPoint();
            
            
            Graph function1 = new Graph(a,b,e);
            
            double xValueAB = Function.XValue(Function.deltaX(a,b), Function.deltaY(a,b));
            double yValueAB = Function.YValue(a, xValueAB);
            /*Console.WriteLine("Y-Achsen Abschnitt: "+yValueAB);
            Console.WriteLine("\n Plot: "+function1.Plot);
            
            Console.WriteLine("E.x:="+ e.y);*/
            
            
            if(function1.Plot > e.y)
                Console.WriteLine("Dein Punkt ist nicht im Viereck");

            Console.ReadKey();
        }
    }
}