using NUnit.Framework;
using SquareCalculator.Calculator;
using SquareCalculator.Shapes;

namespace SquareCalculatorLibrary.Tests
{
    public class CircleSquareCalculatorTests
    {
        [Test]
        public void GetCircleSquare_Test()
        {
            Circle TestCircle = new Circle(4);

            double Square = new CircleSquareCalculator().GetCircleSquare(TestCircle.Radius);
            // 50.2655
            Assert.AreEqual(50.265, Square);
        }
        [Test]
        public void GetShapeSquare_Test()
        {
            double Square = new CircleSquareCalculator().GetShapeSquare(new Circle(4));
            // 50.2655
            Assert.AreEqual(50.265, Square);
        }
    }
}