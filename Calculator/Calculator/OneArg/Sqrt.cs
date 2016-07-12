using System;

namespace Calculator
{
    public class Sqrt: IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sqrt(first);
        }
    }
}