using System;

namespace Calculator.OneArg
{
    public class Sin:IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}