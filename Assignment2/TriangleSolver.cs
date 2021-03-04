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
            if(side1 >=0 && side2 >= 0 && side3 >= 0)
            {
                if (side1 == side2 && side2 == side3 && side3 == side1)
                {
                    resultedString = "A. Form a Trianle. \n B. A triangle with all sides equal Known as EQUILATERAL TRIANGLE";
                }
                else if (side1 == side2 || side2 == side3 || side3 == side1)
                {
                    resultedString = "A. Form a Trianle. \n B. A triangle with two equal sides Known as ISOSCELES TRIANGLE";
                }
                else if (side1 != side2 && side2 != side3 && side3 != side1 && (side1 + side2) != side3 && (side2 + side3) != side1 && (side1 + side3) != side1)
                {
                    resultedString = "A. Form a Trianle. \n B. A triangle with All sides Different Known as SCALENE TRIANGLE";
                }
                else
                    resultedString = "These three sides donot form a triangle";
            }
            else
            {
                resultedString = "These three sides donot form a triangle, sides must be a integer";
             }

            return resultedString;
        }
    }
}
