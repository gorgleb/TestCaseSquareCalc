using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCaseSquareCalc;

public class Triangle : ITriangle
{
    public static double _Side1;
    public static double _Side2;
    public static double _Side3;
    public static double perimeter;
    public Triangle(double Side1,double Side2, double Side3)
    {
        if (Side1<Constants.AccuracyCalculation|| Side2 < Constants.AccuracyCalculation|| Side3 < Constants.AccuracyCalculation)
        {
            throw new NotImplementedException("Sorry, but your side of the triangle is wrong");
        }
        _Side1 = Side1;
        _Side2 = Side2;
        _Side3 = Side3;
    }
    
    public bool RectangularTriangleChecker()
    {
        List<double> Sides = new List<double> { _Side1, _Side2, _Side3};
        Sides.OrderBy(x => x);
        if (Sides[2] == Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2))
        {
            return true;
        }
        else return false;
    }

    public double SquareGetter()
    {
        perimeter = (_Side1 + _Side2 + _Side3) / 2;
        return Math.Sqrt(perimeter * (perimeter - _Side1) * (perimeter - _Side2) * (perimeter - _Side3));

    }
}
