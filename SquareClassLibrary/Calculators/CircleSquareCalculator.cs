using SquareCalculator.Shapes;
using SquareCalculatorLibrary.Calculators;
using System;


namespace SquareCalculator.Calculator
{
    public class CircleSquareCalculator : ShapeSquareCalculator<Circle>
    {
        
        public  double GetCircleSquare(double Radius)
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2),3);
        }

        public override double GetShapeSquare(Circle Shape)
        {
            return Math.Round(Math.PI * Math.Pow(Shape.Radius, 2), 3);
        }
    }
}
