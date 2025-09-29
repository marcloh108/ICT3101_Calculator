using ICT3101_Calculator;
using NUnit.Framework;
using Reqnroll;

namespace SpecFlowCalculatorTest.StepDefinitions
{
    [Binding]
    public class UsingCalculatorFactorialStepDefinitions
    {
        private Calculator _calculator = new Calculator();
        private double _result;

        [When("I have entered {int} into the calculator and press factorial")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(int p0)
        {
            _result = _calculator.Factorial(p0);
        }

        [Then("the factorial result should be {string}")]
        public void ThenTheFactorialResultShouldBe(string expected)
        {
            string formatted = _result.ToString("0");
            NUnit.Framework.Assert.That(formatted, Is.EqualTo(expected));
        }
    }
}
