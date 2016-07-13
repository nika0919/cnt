using System;
using Calculator.OneArg;
using NUnit.Framework;

namespace Calculator.Tests.OneArg
{
    [TestFixture]
    public class LogTests
    {
        [TestCase(1, 0)]
        [TestCase(2, 0.69314)]
 
        public void LogTest(double first, double expected)
        {
            IOneArgCalculator calculator = new Log();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);

        }

        [Test]
        public void LogByNumTest()
        {
            IOneArgCalculator calculator = new Log();
            Assert.Throws<Exception>(() => calculator.Calculate(-1));


        }
    }
}

