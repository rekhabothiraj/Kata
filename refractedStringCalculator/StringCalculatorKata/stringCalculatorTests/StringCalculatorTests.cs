using System;
using NUnit.Framework;
using StringCalculatorKata;

namespace stringCalculatorTests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        private StringCalculator _stringCalculator;

        private const string Emptystring = "";
        private const string StringWithSingleNumber = "2";
        private const string StringWithMultipleNumber = "2,2,2,2,3,3";
        private const string SinglecharDelimter = "2, 2";
        private const string StringWithTwoDelimeters = "1\n2,3";
        private const string StringWithdifferentDelimeters = "1\n2,3;3";
        private const string StringWithSingleNumberAndSingleDelimeter = "3,";
        private const string StringStartingWithDelimeter = "//;\n1;2";

        [SetUp]
        public void SetUp()
        {
            _stringCalculator = new StringCalculator();
        }

        [TestCase(Emptystring, 0)]
        [TestCase(StringWithSingleNumber, 2)]
        [TestCase(StringWithSingleNumberAndSingleDelimeter, 3)]
        public void ShouldCalculateSumOfsingleValueInaString(string input, int output)
        {
            int sumOfValuesOFThestring = _stringCalculator.GetTheSum(input);

            Assert.That(sumOfValuesOFThestring, Is.EqualTo(output));
        }

        [TestCase(SinglecharDelimter, 4)]
        [TestCase(StringWithMultipleNumber, 14)]
        [TestCase(StringWithTwoDelimeters, 6)]
        [TestCase(StringWithdifferentDelimeters, 9)]
        [TestCase(StringWithdifferentDelimeters, 9)]
        public void ShouldCalculateSumOfValuesInaString(string input, int output)
        {
            int sumOfValuesOFThestring = _stringCalculator.GetTheSum(input);

            Assert.That(sumOfValuesOFThestring, Is.EqualTo(output));
        }


        [TestCase("-1")]
        [TestCase("-1,-2")]
        [TestCase("2,2,2,2,3,-3")]
        public void ShouldThrowAnExceptionwhenNegativeNumberIsPassed(string input)
        {
            Assert.Throws<NotSupportedException>(() => _stringCalculator.GetTheSum(input));
        }


        [TestCase(StringStartingWithDelimeter, 3)]
        public void ShouldReturnSumOfValuesInAStringStartingWithDelimeter(string input, int output)
        {
            int sumOfValueInAString = _stringCalculator.GetTheSum(input);
            Assert.That(sumOfValueInAString, Is.EqualTo(output));
        }


        [TestCase("1001,2")]
        public void ShouldNotAllowNumberBiggerThanThousand(string input)
        {
            int sumOfValueInAString = _stringCalculator.GetTheSum(input);
            Assert.That(sumOfValueInAString, Is.EqualTo(2));
        }


        [TestCase("//[*][%]\n1*2%3")]
        public void ShouldNotAllowNumberBiggerThanThousandAndWithManyDelemiters(string input)
        {
            int sumOfValueInAString = _stringCalculator.GetTheSum(input);
            Assert.That(sumOfValueInAString, Is.EqualTo(6));
        }
    }
}