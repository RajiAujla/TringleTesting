using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment2;

namespace TriangleSolverTest
{
    [TestFixture]
    public class TriangleSolverTest
    {

        [Test]
        //1. Test for equilateral triangle with all three equal sides
        public void check_for_equilateral_triangle()
        {
            string result = TriangleSolver.Analyze(11,11,11);
            Assert.AreEqual(11,11,11, result);
        }

        [Test]
        //2. Test for scalene triangle with all three different sides
        public void check_for_scalene_triangle()
        {
            string result = TriangleSolver.Analyze(7,8,9);
            Assert.AreEqual(7,8,9, result);
        }

        [Test]
        //3. Test for isosceles triangle with two equal sides and one different side
        public void check_for_isosceles_triangle()
        {
            string result = TriangleSolver.Analyze(14,14,12);
            Assert.AreEqual(14,14,12, result);
        }

        [Test]
        //4. Test for isosceles triangle first permutations with two equal sides and one different side
        public void check_for_isosceles_triangle_permutations1()
        {
            string result = TriangleSolver.Analyze(14,12,14);
            Assert.AreEqual(14, 12, 14, result);
        }

        [Test]
        //5.Test for isosceles triangle second permutations with two equal sides and one different side
        public void check_for_isosceles_triangle_permutations2()
        {
            string result = TriangleSolver.Analyze(12,14,14);
            Assert.AreEqual(12,14,14, result);
        }

        [Test]
        //6.Test whether given sides form a triangle with 3 integers sides greater than zero
        public void check_for_valid_triangle()
        {
            string result = TriangleSolver.Analyze(2,5,12);
            Assert.AreEqual(2,5,12, result);
        }

        [Test]
        //7.Test whether given sides form a triangle with 3 integers sides and one side is 0
        public void check_for_valid_triangle_oneside_0()
        {
            string result = TriangleSolver.Analyze(0,5,10);
            Assert.AreEqual(0,5,10, result);
        }

        [Test]
        //8.Test whether given sides form a scalene triangle with 3 integers sides and sum of 2 sides not equal to 3 side
        public void check_for_valid_scalene_triangle()
        {
            string result = TriangleSolver.Analyze(2,4, 10);
            Assert.AreEqual(2,4, 10, result);
        }

    }
}
