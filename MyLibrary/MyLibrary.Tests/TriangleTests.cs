using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void TriangleTest_5and5and3_return7_15()
        {   
            Triangle tri = new Triangle(5, 5, 3);
            double expected = 7.15;

            Assert.AreEqual(expected, tri.Square());
        }

        [TestMethod()]
        public void RectangularTest()
        {
            Triangle tri = new Triangle(5, 12, 13);

            Assert.IsTrue(tri.Rectangular());
        }
    }
}