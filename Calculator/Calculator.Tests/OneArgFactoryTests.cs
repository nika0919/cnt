using System;
using Calculator.OneArg;
using Calculator.TwoArg;
using NUnit.Framework;

namespace Calculator.Tests
{
    public class OneArgFactoryTests
    {
        [TestCase("sin", typeof(Sin))]
        [TestCase("cos", typeof(Cos))]
        [TestCase("tg", typeof(Tg))]
        [TestCase("ctg", typeof(Ctg))]
        [TestCase("ln", typeof(Ln))]
        [TestCase("log", typeof(Log))]
        [TestCase("sqrt", typeof(Sqrt))]
        public void OneArgFactotyTest(string name, Type type)
        {
            var calculator = OneArgFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }


    }
}
