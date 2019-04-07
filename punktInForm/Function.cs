namespace punktInForm
{
    public class Function
    {
        public static int deltaX(Point a, Point b)
        {
            return b.x / a.x;
        }
        
        public static int deltaY(Point a, Point b)
        {
            return b.y / a.y;
        }

        public static int XValue(int deltaX, int x)
        {
            return deltaX * x;
        }

        public static int YValue(int deltaY, int y)
        {
            return deltaY*y;
        }
    }
}