using System;

namespace Calculator.OneArg
{
    public class Tg: IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first)/Math.Cos(first);
        }
    }
}