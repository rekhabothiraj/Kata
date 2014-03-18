using System;
using NUnit.Framework;
using StringCalculatorKata;

namespace stringCalculatorTests
{
    [TestFixture]
    public class ConversionOfStringToIntegerTests
    {
        private ConvertStringToInteger _convertStringToInteger;

        [SetUp]
        public void SetUp()
        {
            _convertStringToInteger = new ConvertStringToInteger();
        }

        [Test]
        public void ShouldCreateStringToIntegerConverterClass()
        {
            Assert.That(_convertStringToInteger,Is.Not.Null);
        }
        
        [Test]
        public void ShouldConverStringToInteger()
        {
            var convertedValue = _convertStringToInteger.ConverStringToInteger("");
            Assert.That(convertedValue,Is.EqualTo(0));
        }

        [TestCase("-1")]
         public void ShouldThrowAnExceptionwhenNegativeNumberIsPassed(string input)
        {
            Assert.Throws<NotSupportedException>(() => _convertStringToInteger.ConverStringToInteger(input));
        }
    }
}