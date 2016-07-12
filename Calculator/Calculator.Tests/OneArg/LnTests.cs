using Calculator.OneArg;
using NUnit.Framework;

namespace Calculator.Tests.OneArg
{
    [TestFixture]
    public class LnTests
    {
        [TestCase(1, 0)]
        [TestCase(2, 0.69314)]
        [TestCase(3, 1.09861)]
        public void LnTest(double first, double expected)
        {
            IOneArgCalculator calculator = new Ln();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);

        }
    }
}