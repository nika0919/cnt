using System;

namespace Calculator.OneArg
{
    public class Log:IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
    }
}