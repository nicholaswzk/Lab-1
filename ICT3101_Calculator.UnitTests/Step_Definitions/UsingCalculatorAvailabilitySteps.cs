using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorAvailabilitySteps
    {
        private double _result;

        private readonly Calculator _calculator;

        public UsingCalculatorAvailabilitySteps(Calculator _calculator) // use it as ctor parameter
        {
            this._calculator = _calculator;
        }
        [When(@"I have entered ""(.*)"" and ""(.*)"" into calculator the and press MTBF")]
        public void WhenIHaveEnteredAndIntoCalculatorTheAndPressMTBF(double p0, double p1)
        {
            _result = _calculator.MTBF(p0, p1);
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(double p0, double p1)
        {
            _result = _calculator.Availability(p0, p1);
        }

        [Then(@"the MTBF result should be ""(.*)""")]
        public void ThenTheMTBFResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the availability result should be ""(.*)""")]
        public void ThenTheAvailabilityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the availability result should be positive infinity")]
        public void ThenTheAvailabilityResultShouldBePositiveInfinity()
        {
            Assert.That(_result, Is.EqualTo(Double.PositiveInfinity));
        }
    }
}