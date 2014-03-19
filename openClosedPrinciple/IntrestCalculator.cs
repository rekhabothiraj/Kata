namespace ClassLibrary1
{
    public class IntrestCalculator : IDoIntresetCalculation
    {
        private readonly string _intrest;

        public IntrestCalculator(string intrest)
        {
            _intrest = intrest;
        }

        public IntrestCalculator()
        {
        }

        public string CalculateIntrest()
        {
            if(_intrest == "SI")
                return "SI";

            if (_intrest == "CI")
                return "CI";

            return "";
        }
    }
}