using Calculator.OneArg;
using NUnit.Framework;

namespace Calculator.Tests.OneArg
{
     [TestFixture]
    public class CosTests
    {
         [TestCase(1, 0.54030)]
         [TestCase(5, 0.28366)]
         [TestCase(7, 0.75390)]
         public void CosTest(double first, double expected)
         {
             IOneArgCalculator calculator = new Cos();
             double result = calculator.Calculate(first);
             Assert.AreEqual(expected, result, 0.00001);

         }
    }
}