using System;
using Calculator.OneArg;
using Calculator.TwoArg;
using NUnit.Framework;

namespace Calculator.Tests
{
    public class TwoArgFactoryTests
    {
        [TestCase("add", typeof(Addition))]
        [TestCase("minus", typeof(Deduction))]
        [TestCase("multiply", typeof(Generation))]
        [TestCase("division", typeof(Division))]
        public void TwoArgFactotyTest(string name, Type type)
        {
            var calculator = TwoArgFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}