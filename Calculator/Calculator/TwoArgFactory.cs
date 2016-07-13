using System;
using Calculator.TwoArg;

namespace Calculator
{
    public static class TwoArgFactory 
    {
        /// <summary>
        /// Here we can see, how the buttons interact with functions 
        /// </summary>
        /// <param name="calculatorName">
        /// </param>
        /// <returns>
        /// </returns>
        public static ITwoArgCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "add":
                    return new Addition();
                case "minus":
                    return new Deduction();
                case "multiply":
                    return new Generation();
                case "division":
                    return new Division();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}