using FiguresArea;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FiguresAreaTests
{
    [TestClass]
    public class FiguresAreaTests
    {
        [TestMethod]
        public void FiguresArea()
        {
            var figures = new Figure[] { new Circle(5), new Triangle(3, 4, 5) };
            int expectedArea = 84;
            int actualArea = 0;

            foreach (var figure in figures)
            {
                actualArea += (int)figure.CalculateArea();
            }

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void CircleArea()
        {
            int radius = 5;
            double expectedArea = 78;
            Circle circle = new Circle(radius);

            int actualArea = (int)circle.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void TriangleArea()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            double expectedArea = 6;
            Triangle triangle = new Triangle(a, b, c);

            double actualArea = triangle.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [TestMethod]
        public void RectangularTriangle()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            bool expectedResult = true;
            Triangle triangle = new Triangle(a, b, c);

            bool actualResult = triangle.IsRectangular();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}