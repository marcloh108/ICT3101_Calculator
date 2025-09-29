using System;
using Reqnroll;
using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTest.StepDefinitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilityStepDefinitions
    {
        private Calculator _calculator = new Calculator();
        private double _result;

        [When("I have entered {int} and {int} and {int} into the calculator and press basic current failure intensity")]
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressBasicCurrentFailureIntensity(int lambda0, int v0, int tau)
        {
            _result = _calculator.BasicCurrentFailureIntensity(lambda0, v0, tau);
        }

        [When("I have entered {int} and {int} and {int} into the calculator and press basic expected failures")]
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressBasicExpectedFailures(int lambda0, int v0, int tau)
        {
            _result = _calculator.BasicExpectedFailures(lambda0, v0, tau);
        }

        [Then("the reliability result should be {string}")]
        public void ThenTheReliabilityResultShouldBe(string expected)
        {
            string formatted = _result.ToString("0.#####");
            NUnit.Framework.Assert.That(formatted, Is.EqualTo(expected));
        }
    }
}
