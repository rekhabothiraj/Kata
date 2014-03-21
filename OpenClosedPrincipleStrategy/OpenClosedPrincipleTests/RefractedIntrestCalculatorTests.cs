using NUnit.Framework;
using OpenClosedPrinciple;

namespace OpenClosedPrincipleTests
{
    [TestFixture]
    public class RefractedIntrestCalculatorTests
    {
        [Test]
        public void ShouldCalculateSimpleIntrest()
        {
            var refractedIntrestCalculator = new RefractedIntrestCalculator();
            var intrest = refractedIntrestCalculator.CalculateIntrest("SI");
            Assert.That(intrest, Is.EqualTo("SI"));

        }
    }
}
