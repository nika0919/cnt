﻿namespace Calculator.TwoArg
{
    public class Addition:ITwoArgCalculator
    {
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}