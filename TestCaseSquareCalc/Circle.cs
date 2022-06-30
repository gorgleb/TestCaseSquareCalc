using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCaseSquareCalc
{
    public class Circle : ICircle
    {
        private double _Radius;

        public Circle(double Radius)
        {
            if (Radius - Constants.MinRadius < Constants.AccuracyCalculation)
                throw new NotImplementedException("Sorry,but circle radius is incorrect");
            else
            _Radius = Radius;
        }

        public double SquareGetter()
        {
            return Math.PI * Math.Pow(_Radius, 2);
        }
    }
}
