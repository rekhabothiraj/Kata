namespace OpenClosedPrinciple
{
    public interface IInterestCalculator
    {
        double calculate(double principle_amount, int duration_in_years);
    }
}