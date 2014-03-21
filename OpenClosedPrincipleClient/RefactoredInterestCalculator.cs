namespace OpenClosedPrinciple
{
    public class RefactoredInterestCalculator : IChooseCalculator
    {
        public double interest_calculator_handler(string type_of_interest)
        {
            return InterestCalculatorStrategy.get_for(type_of_interest).calculate(10000.00, 2);
        }
    }
}