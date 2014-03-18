namespace StringCalculatorKata
{
    public class ValidatorNumber : IValidatorNumber
    {
        public int Validate(int inputToBeValidated)
        {
            return inputToBeValidated > 1000 ? 0 : inputToBeValidated;
        }
    }
}