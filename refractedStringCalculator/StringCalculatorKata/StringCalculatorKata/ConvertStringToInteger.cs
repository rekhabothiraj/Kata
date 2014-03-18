using System;

namespace StringCalculatorKata
{
    public class ConvertStringToInteger : IConvertStringToInteger
    {
     
        public int ConverStringToInteger(string value)
        {
            if (value.StartsWith("-"))
               throw new NotSupportedException();
            return value == "" ? 0 : Convert.ToInt32(value);
            
        }

    }
}