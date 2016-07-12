using System;

namespace Calculator
{
    public class Sin:IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}