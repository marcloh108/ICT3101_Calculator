using System;
using Reqnroll;
using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTest.StepDefinitions
{
    [Binding]
    public class UsingCalculatorQualityMetricsStepDefinitions
    {
        private Calculator _calculator = new Calculator();
        private double _result;

        [When("I have entered {int} and {int} into the calculator and press defect density")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDefectDensity(int defects, int size)
        {
            _result = _calculator.DefectDensity(defects, size);
        }

        [Then("the quality metric result should be {string}")]
        public void ThenTheQualityMetricResultShouldBe(string expected)
        {
            string formatted = _result.ToString("0.0#");
            NUnit.Framework.Assert.That(formatted, Is.EqualTo(expected));
        }

        [When("I have entered {int} and {int} and {int} and {int} into the calculator and press current SSI")]
        public void WhenIHaveEnteredAndAndAndIntoTheCalculatorAndPressCurrentSSI(int baseSize, int added, int deleted, int modified)
        {
            _result = _calculator.CurrentSSI(baseSize, added, deleted, modified);
        }

        [Then("the quality metric result should be {string}   # {int} + {int} - {int} - {int} = {int} \\(your slide shows {int} with a different assumption)")]
        public void ThenTheQualityMetricResultShouldBe__YourSlideShowsWithADifferentAssumption(string expected, int baseSize, int added, int deleted, int modified, int result, int slide)
        {
            string formatted = _result.ToString("0");
            NUnit.Framework.Assert.That(formatted, Is.EqualTo(expected));
        }
    }
}
