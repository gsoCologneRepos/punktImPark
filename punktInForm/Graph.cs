namespace punktInForm
{
    public struct Graph
    {
        public double Plot;

        public Graph(Point a, Point b, Point e)
        {
            double xValueAB = Function.XValue(Function.deltaX(a,b), Function.deltaY(a,b));
            double yValueAB = Function.YValue(a, xValueAB);


            Plot = xValueAB * e.X + yValueAB;   
        }
    }
}