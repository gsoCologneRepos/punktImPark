using punktInForm;
using Xunit;
using FluentAssertions;

namespace Tests
{

    public class Test
    {
        private Point[] points;

        public Test()
        {
            points = new Point[]
            {
            new Point(0, 0),
            new Point(5, 0),
            new Point(4, 3),
            new Point(1, 2),
            new Point(0, 0),
            };
        }

        [Fact]
        public void PointInSquare()
        {
            points[4] = new Point(1, 1);
            var result = Program.IsPointInSquare(points);
            result.Should().Be(true);
        }

        [Fact]
        public void PointNotInSquare()
        {
            points[4] = new Point(-1, 1);
            var result = Program.IsPointInSquare(points);
            result.Should().Be(false);
        }

        [Fact]
        public void PointOnTheLine()
        {
            points[4] = new Point(3, 0);
            var result = Program.IsPointInSquare(points);
            result.Should().Be(false);
        }
    }
}
