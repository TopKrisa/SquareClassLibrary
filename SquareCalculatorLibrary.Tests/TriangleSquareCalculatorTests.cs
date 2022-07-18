using NUnit.Framework;
using SquareCalculator.Calculators;
using SquareCalculator.Shapes;

namespace SquareCalculatorLibrary.Tests
{
    public class TriangleSquareCalculatorTests
    {
        [Test]
        public void GetTriangleSquareOnThreeSides_Test()
        {
            Triangle testTriangle = new Triangle(10d,10d,10d);

            double Square = new TriangleSquareCalculator().GetTriangleSquareOnThreeSides(testTriangle.FirstSide, testTriangle.SecondSide,testTriangle.ThirthSide );
            // 43.301
            Assert.AreEqual(43.301, Square);
        }
        [Test]
        public void GetShapeSquare_Test()
        {
            

            double Square = new TriangleSquareCalculator().GetShapeSquare(new Triangle(10d, 10d, 10d));
            // 43.301
            Assert.AreEqual(43.301, Square);
        }



    }
}
