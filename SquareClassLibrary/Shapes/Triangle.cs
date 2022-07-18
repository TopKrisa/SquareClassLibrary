using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculator.Shapes
{
    public class Triangle
    {
     
        public Triangle(double FirstSide, double SecondSide, double ThirthSide)
        {
            this.FirstSide = FirstSide;
            this.SecondSide = SecondSide;
            this.ThirthSide = ThirthSide;
        }

        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirthSide { get; set; }
   
    }
}
