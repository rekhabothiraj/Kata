using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorKata
{
    public class Delimitor : IDoDelimitation
    {
       
     

        public List<string> GetTheDelimitedValue(string input)
        {
            char[] delimiterArray = { ',', '\n', ';', '/', '[', ']', '*', '%' };
            return input.Split(delimiterArray).ToList();
        }
    }
}