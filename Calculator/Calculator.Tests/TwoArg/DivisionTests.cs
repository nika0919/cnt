using NUnit.Framework;

namespace Calculator.Tests.TwoArg
{
     [TestFixture]
    public class DivisionTests
    {

         [TestCase(6, 2, 3)]
         [TestCase(8, 4, 2)]
    
         public void DivisionTest(double first, double second, double expected)
         {
             ITwoArgCalculator calculator = new Division();
             double result = calculator.Calculate(first, second);
             Assert.AreEqual(expected, result);

         }
    }
}
