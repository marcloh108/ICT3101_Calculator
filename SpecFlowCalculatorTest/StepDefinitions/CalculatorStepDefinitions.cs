using ICT3101_Calculator;
using NUnit.Framework;
namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorStepDefinitions
    {
        private readonly Calculator _calculator;
   
        private double _result;

        public UsingCalculatorStepDefinitions(Calculator calculator)
        {
            _calculator = calculator;
        }
        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {

        }
        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _result = _calculator.Add(p0, p1);
        }
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            NUnit.Framework.Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
