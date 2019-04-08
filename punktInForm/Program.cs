using System;
using System.Collections.Generic;

namespace punktInForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Punkt A eingeben:");
            var a = AssignValues.SetPoint();
            Console.WriteLine("Punkt B eingeben:");
            var b = AssignValues.SetPoint();
            Console.WriteLine("Punkt C eingeben:");
            var c = AssignValues.SetPoint();
            Console.WriteLine("Punkt D eingeben:");
            var d = AssignValues.SetPoint();

            Console.WriteLine("Bitte gewünschten Punkt eingeben:");
            var e = AssignValues.SetPoint();
            
            var functionAB = new Graph(a, b, e);
            var functionCD = new Graph(d, c, e);
            var functionAD = new Graph(a, d, e);
            var functionBC = new Graph(c, b, e);
            var ADIsGood = false;
            var BCIsGood = false;

            if (double.IsNaN(functionAD.Plot))
            {
                ADIsGood = a.X < e.X;
            }
            else
            {
                ADIsGood = functionAD.Plot > e.Y;
            }

            if (double.IsNaN(functionBC.Plot))
            {
                BCIsGood = b.X > e.X;
            }
            else
            {
                BCIsGood = functionBC.Plot < e.Y;
            }


            if (ADIsGood &&
                BCIsGood &&
                functionAB.Plot < e.Y &&
                functionCD.Plot > e.Y)
            {
                Console.WriteLine("Dein Punkt ist im Viereck");
            }
            else
            {
                Console.WriteLine("Dein Punkt ist nicht im Viereck");
            }

            Console.ReadKey();
        }
    }
}