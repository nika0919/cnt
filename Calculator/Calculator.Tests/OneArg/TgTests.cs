using Calculator.OneArg;
using NUnit.Framework;

namespace Calculator.Tests.OneArg
{
     [TestFixture]
    public class TgTests
    {
         [TestCase(1, 1.55740)]
         [TestCase(3, -0.14254)]
         public void TgTest(double first, double expected)
         {
             IOneArgCalculator calculator = new Tg();
             double result = calculator.Calculate(first);
             Assert.AreEqual(expected, result, 0.00001);

         }
    }
}