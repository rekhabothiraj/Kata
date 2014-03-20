using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var refractedIntrestCalculator = new RefractedIntrestCalculator(new SimpleIntestCalculator());
            var intrest = refractedIntrestCalculator.CalculateIntrest();
            Assert.That(intrest, Is.EqualTo("SI"));

        }
    }
}
