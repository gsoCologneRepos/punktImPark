using System;

namespace punktInForm
{
    class Program
    {
        static void Main(string[] args)
        {
            var points = new Point[5];

            Console.WriteLine("Punkt A eingeben:");
            points[0] = AssignValues.SetPoint();
            Console.WriteLine("Punkt B eingeben:");
            points[1] = AssignValues.SetPoint();
            Console.WriteLine("Punkt C eingeben:");
            points[2] = AssignValues.SetPoint();
            Console.WriteLine("Punkt D eingeben:");
            points[3] = AssignValues.SetPoint();

            Console.WriteLine("Bitte gewünschten Punkt eingeben:");
            points[4] = AssignValues.SetPoint();
            
            if(IsPointInSquare(points))
            {
                Console.WriteLine("Dein Punkt ist im Viereck");
            }
            else
            {
                Console.WriteLine("Dein Punkt ist nicht im Viereck");
            }

            Console.ReadKey();
        }

        public static bool IsPointInSquare(Point[] points)
        {
            if(points.Length != 5)
            {
                return false;
            }

            var functionAB = new Graph(points[0], points[1], points[4]);
            var functionCD = new Graph(points[3], points[2], points[4]);
            var functionAD = new Graph(points[0], points[3], points[4]);
            var functionBC = new Graph(points[2], points[1], points[4]);
            var ADIsGood = false;
            var BCIsGood = false;

            if (double.IsNaN(functionAD.Plot))
            {
                ADIsGood = points[0].X < points[4].X;
            }
            else
            {
                ADIsGood = functionAD.Plot > points[4].Y;
            }

            if (double.IsNaN(functionBC.Plot))
            {
                BCIsGood = points[1].X > points[4].X;
            }
            else
            {
                BCIsGood = functionBC.Plot < points[4].Y;
            }

            return ADIsGood &&
                   BCIsGood &&
                   functionAB.Plot < points[4].Y &&
                   functionCD.Plot > points[4].Y;
        }
    }
}