using NUnit.Framework;
using OpenClosedPrinciple;

namespace OpenClosedPrincipleTests
{
    [TestFixture]
    public class IntrestCalculatorTests
    {
        [Test]
        public void ShouldCreateAIntersetCalculatorClass()
        {
            var intrestCalculator = new IntrestCalculator();
            Assert.That(intrestCalculator, Is.Not.Null);
        }


        [Test]
        public void ShouldCalculateSimpleIntreset()
        {
            var intrestCalculator = new IntrestCalculator("SI");
            string calculatedIntrest = intrestCalculator.CalculateIntrest();
            Assert.That(calculatedIntrest, Is.EqualTo("SI"));
        }

        [Test]
        public void ShouldCalculateCompoundIntrestIntreset()
        {
            var intrestCalculator = new IntrestCalculator("CI");
            string calculatedIntrest = intrestCalculator.CalculateIntrest();
            Assert.That(calculatedIntrest, Is.EqualTo("CI"));
        }
    }
}
