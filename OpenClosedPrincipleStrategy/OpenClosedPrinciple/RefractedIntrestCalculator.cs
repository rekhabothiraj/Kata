using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;

namespace OpenClosedPrinciple
{
    public class RefractedIntrestCalculator : IChooseCalculator
    {
        private readonly List<IDoIntresetCalculation> _calculatorList;

        public RefractedIntrestCalculator()
        {
            _calculatorList = new List<IDoIntresetCalculation>
            {
                new SimpleIntestCalculator()
            };
        }

        public string CalculateIntrest(string typeOfIntrest)
        {
            var doIntresetCalculation = _calculatorList.FirstOrDefault(m =>m.MatchIntrest(typeOfIntrest));
            return doIntresetCalculation != null ? doIntresetCalculation.CalculateIntrest(typeOfIntrest) : "";
        }
    }
}