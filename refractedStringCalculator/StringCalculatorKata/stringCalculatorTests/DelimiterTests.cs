using System.Collections.Generic;
using NUnit.Framework;
using StringCalculatorKata;

namespace stringCalculatorTests
{
    [TestFixture]
    public class DelimiterTests
    {
        private Delimitor _conversion;

        [SetUp]
        public void SetUp()
        {
            _conversion = new Delimitor();
        }

        [Test]
        public void ShouldCreateAConversionObject()
        {
            Assert.That(_conversion, Is.Not.Null);
        }

        
        [Test]
        public void ShouldReturnDelimetedarrayValue()
        {
            List<string> theDelimitedValue = _conversion.GetTheDelimitedValue("");

            Assert.That(theDelimitedValue.Count, Is.EqualTo(1));
        }
    }
}