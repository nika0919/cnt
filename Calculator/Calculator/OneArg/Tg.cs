using System;

namespace Calculator
{
    public class Tg: IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first)/Math.Cos(first);
        }
    }
}