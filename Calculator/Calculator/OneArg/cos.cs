using System;

namespace Calculator.OneArg
{
    public class Cos : IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }

    }
}