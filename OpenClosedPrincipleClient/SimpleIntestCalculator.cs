using System;

namespace OpenClosedPrinciple
{
    public class SimpleIntestCalculator : IDoIntresetCalculation
    {
        public string CalculateIntrest(string typeOfInterest)
        {
            return "SI";
        }

        public bool MatchIntrest(string typeOfIntrest)
        {
            const string strB = "SI";
            return (String.Compare(typeOfIntrest, strB, StringComparison.OrdinalIgnoreCase) == 0);
        }
    }


}