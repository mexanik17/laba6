using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class StringTasksTests
    {
        [TestMethod]
        public void GetFirstNUppercaseLetters_ValidInput_ReturnsCorrectString()
        {
            Assert.AreEqual("ABCDE", StringTasks.GetFirstNUppercaseLetters(5));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetFirstNUppercaseLetters_InvalidInput_ThrowsArgumentException()
        {
            StringTasks.GetFirstNUppercaseLetters(27);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SumOfDigits_ValidInput_ReturnsCorrectSum()
        {
            StringTasks.SumOfDigits("123a");
        }

        [TestMethod]
        public void Integrate_SimpleFunction_ReturnsCorrectValue()
        {
            Func<double, double> func = x => x;
            double result = MathTasks.Integrate(func, 0, 1);
            Assert.AreEqual(0.5, result, 0.01);
        }

    }
}
