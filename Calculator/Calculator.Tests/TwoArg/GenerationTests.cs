using Calculator.TwoArg;
using NUnit.Framework;

namespace Calculator.Tests.TwoArg
{
     [TestFixture]
    public class GenerationTests
    {
         [TestCase(6, 2, 12)]
         [TestCase(5, 2, 10)]
         [TestCase(7, 2, 14)]
         public void GenerationTest(double first, double second, double expected)
         {
             ITwoArgCalculator calculator = new Generation();
             double result = calculator.Calculate(first, second);
             Assert.AreEqual(expected, result);

         }
    }
}