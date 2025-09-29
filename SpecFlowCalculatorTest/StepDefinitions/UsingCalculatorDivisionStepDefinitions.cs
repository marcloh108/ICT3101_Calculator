using ICT3101_Calculator;
using NUnit.Framework;
using Reqnroll;

namespace SpecFlowCalculatorTest.StepDefinitions
{
    [Binding]
    public class UsingCalculatorDivisionStepDefinitions
    {
        private Calculator _calculator;
        private double _result;

        // No DI; lazy-create the calculator when needed.
        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(double a, double b)
        {
            _calculator ??= new Calculator();
            _result = _calculator.Divide(a, b);
        }

        // One assertion covers 0, 1, 0.5, etc.
        [Then(@"the division result should be (.*)")]
        public void ThenTheDivisionResultShouldBe(double expected)
        {
            NUnit.Framework.Assert.That(_result, Is.EqualTo(expected).Within(1e-9));
        }

        [Then(@"the division result equals positive_infinity")]
        public void ThenTheDivisionResultEqualsPositive_Infinity()
        {
            NUnit.Framework.Assert.That(double.IsPositiveInfinity(_result));
        }
    }
}
