using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MicrosoftTestFrameworkDemo
{
    [TestClass]
    public class CalculateTest
    {
        Calculate cal = null;

        [TestInitialize]
        public void Setup()
        {
            cal = new Calculate();
        }

        [TestMethod]
        public void Addition()
        {
            int actual = cal.Addition(20, 30);
            int expected = 50;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subtract()
        {
            int actual = cal.Subtract(20, 30);
            int expected = 10;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Multiply()
        {
            int actual = cal.Multiply(20, 30);
            int expected = 600;
            Assert.AreEqual(expected, actual);
        }

        [TestCleanup]
        public void TearDown()
        {
            cal = null;
        }
    }
}
