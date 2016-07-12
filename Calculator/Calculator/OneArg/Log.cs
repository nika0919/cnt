using System;

namespace Calculator
{
    public class Log:IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
    }
}