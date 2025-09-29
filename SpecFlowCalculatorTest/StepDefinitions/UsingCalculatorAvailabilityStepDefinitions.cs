using ICT3101_Calculator;
using Reqnroll;
using NUnit.Framework;

namespace SpecFlowCalculatorTest.StepDefinitions
{
    [Binding]
    public class UsingCalculatorAvailabilityStepDefinitions
    {
        private Calculator _calculator = new Calculator();
        private double _result;

        [When("I have entered {int} and {int} into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(int mttf, int mttr)
        {
            _result = _calculator.MTBF(mttf, mttr);
        }

        [When("I have entered {int} and {int} into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(int mttf, int mttr)
        {
            _result = _calculator.AvailabilityFromMttfMttr(mttf, mttr);
        }

        [Then("the availability result should be {string}")]
        public void ThenTheAvailabilityResultShouldBe(string expected)
        {
            // Format result to 5 decimal places for comparison
            string formatted = _result.ToString("0.#####");
            NUnit.Framework.Assert.That(formatted, Is.EqualTo(expected));
        }
    }
}