using System;
using Calculator.TwoArg;

namespace Calculator
{
    public class SortingFactory
    {
        public static ISorting CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "quick":
                 
                    return new Sorting();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}