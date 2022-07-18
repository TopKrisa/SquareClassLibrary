
namespace SquareCalculatorLibrary.Calculators
{
    public abstract class ShapeSquareCalculator<T> where T :class
    {
        public abstract double GetShapeSquare(T Shape);

    }
}
