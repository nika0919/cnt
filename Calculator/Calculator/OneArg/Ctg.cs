using System;

namespace Calculator.OneArg
{
    public class Ctg:IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first)/Math.Sin(first);
        }
    }
}