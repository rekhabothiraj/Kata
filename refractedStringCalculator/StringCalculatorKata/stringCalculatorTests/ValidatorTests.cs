using NUnit.Framework;
using StringCalculatorKata;

namespace stringCalculatorTests
{
    [TestFixture]
    public class ValidatorTests
    {
        private ValidatorNumber _validator;

        [SetUp]
        public void SetUp()
        {
            _validator = new ValidatorNumber();
        }

        [Test]
        public void ShouldCreateAValidationObject()
        {
            Assert.That(_validator,Is.Not.Null);
        }



        [Test]
        public void ShouldValidateTheNumberAndRetrunTHeSameWhenItIsLessThan1000_AndGreaterThan0()
        {
            var validatedValue = _validator.Validate(1000);
            Assert.That(validatedValue,Is.EqualTo(1000));
        }

        [Test]
        public void ShouldValidateTheInputAndReturnZeroWhenItISGreaterThan1000()
        {
            var validatedValue = _validator.Validate(1001);
            Assert.That(validatedValue, Is.EqualTo(0));
        }
    }
}