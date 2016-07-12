using Calculator.OneArg;
using NUnit.Framework;

namespace Calculator.Tests.OneArg
{
     [TestFixture]
    public class CtgTests
    {
         [TestCase(1, 0.64209)]
         
         public void CtgTest(double first, double expected)
         {
             IOneArgCalculator calculator = new Ctg();
             double result = calculator.Calculate(first);
             Assert.AreEqual(expected, result, 0.00001);

         }
    }
}