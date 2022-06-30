using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCaseSquareCalc
{
    public interface ITriangle:IFigure
    {
       public static double Side1 { get; }
       public static double Side2 { get; }
       public static double Side3 { get; }

        public bool RectangularTriangleChecker();
    }
}
