using System;

namespace Calculator.OneArg
{
    public class Sqrt: IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sqrt(first);
        }
    }
}