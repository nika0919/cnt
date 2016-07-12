using Calculator.OneArg;
using NUnit.Framework;

namespace Calculator.Tests.OneArg
{
    [TestFixture]
    public class SqrtTests
    {
        [TestCase(1, 1)]
        [TestCase(4, 2)]
        [TestCase(9, 3)]
        public void SqrtTest(double first, double expected)
        {
            IOneArgCalculator calculator = new Sqrt();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);

        }
    }
}