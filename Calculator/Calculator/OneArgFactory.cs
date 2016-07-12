using System;
using Calculator.OneArg;

namespace Calculator
{
    public static class OneArgFactory
    {
        public static IOneArgCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "sin":
                    return new Sin();
                case "cos":
                    return new Cos();
                case "ctg":
                    return new Ctg();
                case "tg":
                    return new Tg();
                case "log":
                    return new Log();
                case "ln":
                    return new Ln();
                case "sqrt":
                    return  new Sqrt();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}