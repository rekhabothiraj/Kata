namespace OpenClosedPrinciple
{
    public interface IDoIntresetCalculation : IChooseCalculator
    {
       bool MatchIntrest(string typeOfIntrest);
    }


    public interface IChooseCalculator
    {
        string CalculateIntrest(string typeOfInterest);
    }
}