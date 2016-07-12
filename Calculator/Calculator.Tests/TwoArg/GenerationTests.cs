using Calculator.TwoArg;
using NUnit.Framework;

namespace Calculator.Tests.TwoArg
{
     [TestFixture]
    public class GenerationTests
    {
         [Test]
         public void AdditionTest()
         {
             ITwoArgCalculator calculator = new Generation();
             double result = calculator.Calculate(6, 2);
             Assert.AreEqual(12, result);

         }
    }
}