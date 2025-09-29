using System;
using Reqnroll;
using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTest.StepDefinitions
{
    [Binding]
    public class UsingCalculatorReliabilityLogStepDefinitions
    {
        private Calculator _calculator = new Calculator();
        private double _result;

        [When("I have entered {int} and {float} and {int} into the calculator and press log current failure intensity")]
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressLogCurrentFailureIntensity(int lambda0, decimal theta, int tau)
        {
            _result = _calculator.LogCurrentFailureIntensity(lambda0, (double)theta, tau);
        }

        [Then("the reliability result should be {string}  # {int} * exp\\({float}*{int})")]
        public void ThenTheReliabilityResultShouldBeExp(string expected, int lambda0, decimal theta, int tau)
        {
            string formatted = _result.ToString("0.#####");
            NUnit.Framework.Assert.That(formatted, Is.EqualTo(expected));
        }

        [When("I have entered {int} and {float} and {int} into the calculator and press log expected failures")]
        public void WhenIHaveEnteredAndAndIntoTheCalculatorAndPressLogExpectedFailures(int lambda0, decimal theta, int tau)
        {
            _result = _calculator.LogExpectedFailures((double)theta, lambda0, tau);
        }

        [Then("the reliability result should be {string}  # \\({int}\\/θ)*ln\\({int}+λ{int}*θ*τ)")]
        public void ThenTheReliabilityResultShouldBeΘLnΛΘΤ(string expected, int one, int lambda0, int tau)
        {
            string formatted = _result.ToString($"F{expected.Split('.').ElementAtOrDefault(1)?.Length ?? 0}");
            NUnit.Framework.Assert.That(formatted, Is.EqualTo(expected));
        }

        [Then("the reliability result should be {string}  # matches slide order-of-magnitude")]
        public void ThenTheReliabilityResultShouldBeMatchesSlideOrder_Of_Magnitude(string expected)
        {
            string formatted = _result.ToString($"F{expected.Split('.').ElementAtOrDefault(1)?.Length ?? 0}");
            NUnit.Framework.Assert.That(formatted, Is.EqualTo(expected));
        }
    }
}
