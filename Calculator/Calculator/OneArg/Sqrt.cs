using System;

namespace Calculator.OneArg
{
    public class Sqrt: IOneArgCalculator
    {
        public double Calculate(double first)
        {
            if (first < 0)
            {
                throw new Exception("Неправильное значение");
            }
            return Math.Sqrt(first);
        }
    }
}