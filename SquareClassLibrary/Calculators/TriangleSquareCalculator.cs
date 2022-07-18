using SquareCalculator.Shapes;
using SquareCalculatorLibrary.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculator.Calculators
{
    public class TriangleSquareCalculator : ShapeSquareCalculator<Triangle>
    {   
        public double GetTriangleSquareOnThreeSides(double FirstSide, double SecondSide, double ThirthSide)
        {
            double HalfPerimeter = (FirstSide + SecondSide + ThirthSide) / 2;
            return Math.Round(Math.Sqrt(HalfPerimeter *
                (HalfPerimeter - FirstSide) *
                (HalfPerimeter - SecondSide) *
                (HalfPerimeter - ThirthSide)),3);
        }

        public override double GetShapeSquare(Triangle Shape)
        {
            double HalfPerimeter = (Shape.FirstSide + Shape.SecondSide + Shape.ThirthSide) / 2;
            return Math.Round(Math.Sqrt(HalfPerimeter *
                (HalfPerimeter - Shape.FirstSide) *
                (HalfPerimeter - Shape.SecondSide) *
                (HalfPerimeter - Shape.ThirthSide)), 3);
        }
    }
}
