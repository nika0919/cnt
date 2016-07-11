namespace Calculator
{
    public class Deduction:ITwoArgCalculator
    {
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}