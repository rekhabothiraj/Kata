namespace StringCalculatorKata
{
    public class StringCalculator
    {
        private readonly IDoDelimitation _delimitor;
        private readonly IConvertStringToInteger _convertStringToInteger;
        private readonly IValidatorNumber _validatorNumber;

        public StringCalculator():this(new Delimitor(),new ConvertStringToInteger(),new ValidatorNumber())
        {
            
        }
        public StringCalculator(IDoDelimitation delimitor, IConvertStringToInteger convertStringToInteger,IValidatorNumber validatorNumber)
        {
            _delimitor = delimitor;
            _convertStringToInteger = convertStringToInteger;
            _validatorNumber = validatorNumber;
        }

        public int  GetTheSum(string input)
        {
            var theDelimitedValue = _delimitor.GetTheDelimitedValue(input);

            int result = 0;
            foreach (string s in theDelimitedValue)
            {
                int convertedValue = _convertStringToInteger.ConverStringToInteger(s);
                int validatedValue = _validatorNumber.Validate(convertedValue);
                result = result + validatedValue;
            }
            return result;
        }

    }
}