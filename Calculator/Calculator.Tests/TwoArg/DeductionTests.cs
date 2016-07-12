using Calculator.TwoArg;
using NUnit.Framework;

namespace Calculator.Tests.TwoArg
{
    [TestFixture]

    public class DeductionTests
    {
        [TestCase(7, 3, 4)]
        [TestCase(8, 3, 5)]
        [TestCase(120, 79, 41)]
        public void DeductionTest(double first, double second, double expected)
        {
            ITwoArgCalculator calculator = new Deduction();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);

        }
    }
}