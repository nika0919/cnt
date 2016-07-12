using Calculator.OneArg;
using Calculator.TwoArg;
using NUnit.Framework;

namespace Calculator.Tests.OneArg
{
     [TestFixture]
    public class SinTests
    {
         [TestCase(1, 0.84147)]
         [TestCase(2, 0.90929)]
         [TestCase(3, 0.14112)]
         public void SinTest(double first, double expected)
         {
             IOneArgCalculator calculator = new Sin();
             double result = calculator.Calculate(first);
             Assert.AreEqual(expected, result, 0.00001);

         }
    }
}