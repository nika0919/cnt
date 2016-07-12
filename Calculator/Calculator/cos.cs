using System;

namespace Calculator
{
    public class Cos : IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }

    }
}