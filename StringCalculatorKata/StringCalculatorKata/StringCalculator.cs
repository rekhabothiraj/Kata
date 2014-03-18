using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        private readonly Conversion _conversion;

        public StringCalculator(string input)
        {
            _conversion = new Conversion(input);
        }
        
        public int  GetTheCalculatedValue()
        {
            var theDelimitedValue = _conversion.GetTheDelimitedValue();

            return theDelimitedValue.Aggregate(0, (current, numberInThestring) => current + _conversion.GetTheValueOfTheStringInInteger(numberInThestring));
        }

    }

    public class Conversion
    {
        private readonly string _input;

        public Conversion(string input)
        {
            _input = input;
        }

        public int GetTheValueOfTheStringInInteger(string value)
        {
            return value == "" ? 0 : ConvertToInteger(value);
        }

        private static int ConvertToInteger(string value)
        {
            if (value.StartsWith("-"))
                throw new NotSupportedException();

            var convertedValue = Convert.ToInt32(value);
            return convertedValue > 1000 ? 0 : convertedValue;
        }

        public List<string> GetTheDelimitedValue()
        {
            char[] delimiterArray = { ',', '\n', ';', '/', '[', ']', '*', '%' };
            return _input.Split(delimiterArray).ToList();
        }
    }
}