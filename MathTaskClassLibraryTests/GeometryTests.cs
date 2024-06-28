using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTaskClassLibrary;
using MathClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void CalculateArea_ValidInputs_ReturnsCorrectResult()
        {
            var geometry = new Geometry();
            int length = 3;
            int width = 5;
            int expected = 15;

            int result = geometry.CalculateArea(length, width);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateArea_NegativeLength_ThrowsArgumentException()
        {
            var geometry = new Geometry();
            geometry.CalculateArea(-4, 10);
        }
    }
}
