using System;

namespace Calculator
{
    public class Division:ITwoArgCalculator
    {
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Делить на нуль нельзя");
            }
            return first / second;
        }
    }
}