using System.Collections.Generic;
using NUnit.Framework;
using StringCalculatorKata;

namespace stringCalculatorTests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        StringCalculator _stringCalculator;

        const string Emptystring = "";
        const string StringWithSingleNumber = "2";
        private const string StringWithMultipleNumber = "2,2,2,2,3,3";
        const string SinglecharDelimter = "2, 2";
        const string StringWithTwoDelimeters = "1\n2,3";
        const string StringWithdifferentDelimeters = "1\n2,3;3";
        const string StringWithSingleNumberAndSingleDelimeter = "3,";
        const string StringStartingWithDelimeter = "//;\n1;2";

      
        [TestCase(Emptystring, 0)]
        [TestCase(StringWithSingleNumber, 2)]
        [TestCase(StringWithSingleNumberAndSingleDelimeter, 3)]
       public void ShouldCalculateSumOfsingleValueInaString(string input, int output)
        {
            _stringCalculator = new StringCalculator(input);
            var sumOfValuesOFThestring = _stringCalculator.GetTheCalculatedValue();

            Assert.That(sumOfValuesOFThestring, Is.EqualTo(output));
        }

        [TestCase(SinglecharDelimter, 4)]
        [TestCase(StringWithMultipleNumber, 14)]
        [TestCase(StringWithTwoDelimeters, 6)]
        [TestCase(StringWithdifferentDelimeters, 9)]
        [TestCase(StringWithdifferentDelimeters, 9)]
        public void ShouldCalculateSumOfValuesInaString(string input, int output)
        {
            _stringCalculator = new StringCalculator(input);

            var sumOfValuesOFThestring = _stringCalculator.GetTheCalculatedValue();

            Assert.That(sumOfValuesOFThestring, Is.EqualTo(output));
        }



        [TestCase("-1")]
        [TestCase("-1,-2")]
        [TestCase("2,2,2,2,3,-3")]
        public void ShouldThrowAnExceptionwhenNegativeNumberIsPassed(string input)
        {
            _stringCalculator = new StringCalculator(input);

            Assert.Throws<System.NotSupportedException>(() => _stringCalculator.GetTheCalculatedValue());
        }


        [TestCase(StringStartingWithDelimeter, 3)]
        public void ShouldReturnSumOfValuesInAStringStartingWithDelimeter(string input, int output)
        {
            _stringCalculator = new StringCalculator(input);

            var sumOfValueInAString = _stringCalculator.GetTheCalculatedValue();
            Assert.That(sumOfValueInAString, Is.EqualTo(output));
        }



        [TestCase("1001,2")]
        public void ShouldNotAllowNumberBiggerThanThousand(string input)
        {
            _stringCalculator = new StringCalculator(input);

            var sumOfValueInAString = _stringCalculator.GetTheCalculatedValue();
            Assert.That(sumOfValueInAString, Is.EqualTo(2));
        }


        [TestCase("//[*][%]\n1*2%3")]
        public void ShouldNotAllowNumberBiggerThanThousandAndWithManyDelemiters(string input)
        {
            _stringCalculator = new StringCalculator(input);

            var sumOfValueInAString = _stringCalculator.GetTheCalculatedValue();
            Assert.That(sumOfValueInAString, Is.EqualTo(6));
        }


        [Test]
        public void ShouldCreateAConversionObject()
        {
            var conversion = new Conversion("1");
            Assert.That(conversion,Is.Not.Null);
        }


        [Test]
        public void ShouldConvertStringToInt()
        {
            var conversion = new Conversion("");
            var theValueOfTheStringInInteger = conversion.GetTheValueOfTheStringInInteger("");

            Assert.That(theValueOfTheStringInInteger,Is.EqualTo(0));
        }


        [Test]
        public void ShouldReturnDelimetedarrayValue()
        {
            var conversion = new Conversion("");
            var theDelimitedValue = conversion.GetTheDelimitedValue();  

            Assert.That(theDelimitedValue.Count, Is.EqualTo(1));
        }
    }
}