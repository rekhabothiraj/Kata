namespace OpenClosedPrinciple
{
    public class RefractedIntrestCalculator : IDoIntresetCalculation
    {
        private readonly IDoIntresetCalculation _intresetCalculation;

        public RefractedIntrestCalculator(IDoIntresetCalculation intresetCalculation)
        {
            _intresetCalculation = intresetCalculation;
        }

        public string CalculateIntrest()
        {
            return _intresetCalculation.CalculateIntrest();
        }
    }
}