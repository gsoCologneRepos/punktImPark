using punktInForm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Test
    {

        private Point[] points = new Point[]
        {
            new Point(0, 0),
            new Point(5, 0),
            new Point(4, 3),
            new Point(1, 2),
            new Point(0, 0),
        };

        [TestMethod]
        public void PointInSquare()
        {
            points[4] = new Point(1, 1);
           
        }

        [TestMethod]
        public void PointNotInSquare()
        {
            points[4] = new Point(-1, 1);
        }

        [TestMethod]
        public void PointOnTheLine()
        {
            points[4] = new Point(3, 0);
        }
    }
}
