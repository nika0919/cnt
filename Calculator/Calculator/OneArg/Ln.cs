using System;

namespace Calculator.OneArg
{
    public class Ln:IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first, Math.E);
        }
    }
}