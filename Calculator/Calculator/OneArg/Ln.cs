using System;

namespace Calculator.OneArg
{
    public class Ln:IOneArgCalculator
    {
        public double Calculate(double first)
        {
            if (first < 0)
            {
                throw new Exception("Неправильное значение");
            }
            return Math.Log(first, Math.E);
        }
    }
}