using System;

namespace Calculator
{
    public class Ctg:IOneArgCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first)/Math.Sin(first);
        }
    }
}