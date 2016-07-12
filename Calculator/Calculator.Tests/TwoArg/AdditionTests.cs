using Calculator.TwoArg;
using NUnit.Framework;

namespace Calculator.Tests.TwoArg
{
[TestFixture]
    public class AdditionTests
    {
     [TestCase(6, 2, 8)]
     [TestCase(5, 2, 7)]
     [TestCase(7, 2, 9)]
    public void AdditionTest(double first, double second, double expected)
    {
        ITwoArgCalculator calculator= new Addition();
        double result = calculator.Calculate(first, second);
        Assert.AreEqual(expected,result);

    }
        
    }
}