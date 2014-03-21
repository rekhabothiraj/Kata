using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    public class InterestCalculatorStrategy
    {
        private static readonly Dictionary<string,IInterestCalculator>  dictionary = new Dictionary<string, IInterestCalculator>();

        private static InterestCalculatorStrategy SimpleInterest = new InterestCalculatorStrategy("SI", new SimpleInterestCalculator());
        private static InterestCalculatorStrategy CompoundInterest = new InterestCalculatorStrategy("CI", new CompoundInterestCalculator());

        private InterestCalculatorStrategy(string type_of_calculator, IInterestCalculator interest_calculator)
        {
            dictionary.Add(type_of_calculator, interest_calculator);           
        }

        public static IInterestCalculator get_for(string key)
        {
            IInterestCalculator calculator;
            dictionary.TryGetValue(key, out calculator);
            return calculator;
        }
    }
}