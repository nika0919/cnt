﻿namespace Calculator.TwoArg
{
    public class Generation:ITwoArgCalculator
    {
        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}