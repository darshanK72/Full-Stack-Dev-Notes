using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalculateDemo;

namespace CaclulateTest
{
    [TestFixture]
    public class CalculateTestClass
    {
        Calculate cal = null;

        [SetUp]
        public void Setup()
        {
            cal = new Calculate();
        }

        [Test]
        public void Addition()
        {
            int actual = cal.Addition(20, 30);
            int expected = 50;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Subtract()
        {
            int actual = cal.Subtract(20, 30);
            int expected = 10;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Multiplication()
        {
            int actual = cal.Multiplication(20, 30);
            int expected = 600;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Ignore("Will Test this Later")]
        public void Divide()
        {
            int actual = cal.Divide(12, 4);
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideWithException()
        {
            int actual = cal.Divide(12, 0);
        }

        [TearDown]
        public void TearDown()
        {
            cal = null;
        }
    }
}
