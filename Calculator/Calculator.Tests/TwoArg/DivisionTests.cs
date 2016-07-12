using NUnit.Framework;

namespace Calculator.Tests.TwoArg
{
     [TestFixture]
    public class DivisionTests
    {

         [Test]
         public void AdditionTest()
         {
             ITwoArgCalculator calculator = new Division();
             double result = calculator.Calculate(6, 2);
             Assert.AreEqual(3, result);

         }
    }
}
