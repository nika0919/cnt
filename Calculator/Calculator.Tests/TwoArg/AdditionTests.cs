using Calculator.TwoArg;
using NUnit.Framework;

namespace Calculator.Tests.TwoArg
{
[TestFixture]
    public class AdditionTests
    {
    [Test]
    public void AdditionTest()
    {
        ITwoArgCalculator calculator= new Addition();
        double result = calculator.Calculate(3, 5);
        Assert.AreEqual(8,result);

    }
        
    }
}