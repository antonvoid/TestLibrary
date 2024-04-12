using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Tests
{
    [TestClass()]
    public class LibraryTests
    {
        [TestMethod()]
        public void AreaCalculationСircleTest()
        {
            double r = 1;
            double expected = Math.PI;

            double actual = Library.AreaCalculation(r);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void AreaCalculationTriangleTest()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            double actual = Library.AreaCalculation(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckingSquarenessTest()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            bool expected = true;

            bool actual = Library.CheckingSquareness(a, b, c);
            Assert.AreEqual(expected, actual);
        }
    }
}