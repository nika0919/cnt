using System;

namespace Calculator.OneArg
{
   
    public class Log:IOneArgCalculator
    {
      
        public double Calculate(double first)
        {
            if (first < 0)
            {
                throw new Exception("Неправильное значение");
            }
            return Math.Log(first);
        }
    }
}