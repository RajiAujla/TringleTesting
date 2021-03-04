using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public static class TriangleSolver
    {
        static string resultedString;
        public static string Analyze(int side1,int side2,int side3)
        {
            if (side1 == side2 && side2 == side3 && side3 == side1)
            {
                resultedString = "A. Form a Trianle. \n B. A triangle with all sides equal Known as EQUILATERAL TRIANGLE";
            } else if (side1 == side2 || side2 == side3 || side3 == side1)
            {
                resultedString = "A. Form a Trianle. \n B. A triangle with two sides equal Known as ISOSCELES TRIANGLE";
            } else if (side1 != side2 && side2 != side3 && side3 != side1)
            {
                resultedString = "A. Form a Trianle. \n B. A triangle with All sides Different Known as SCALENE TRIANGLE";
            } else
                resultedString = "These three sides donot form a triangle";

            return resultedString;
        }
    }
}
