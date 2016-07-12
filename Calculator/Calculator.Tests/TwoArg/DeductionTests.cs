using Calculator.TwoArg;
using NUnit.Framework;

namespace Calculator.Tests.TwoArg
{
    [TestFixture]

    public class DeductionTests
    {
        [Test]
        public void AdditionTest()
        {
            ITwoArgCalculator calculator = new Deduction();
            double result = calculator.Calculate(5, 2);
            Assert.AreEqual(3, result);

        }
    }
}