Feature: UsingCalculatorBasicReliability
  In order to calculate the Basic Musa model's failures/intensities
  As a Software Quality Metric enthusiast
  I want to use my calculator to do this

@Reliability
Scenario: Current failure intensity λ(τ)
  Given I have a calculator
  When I have entered 10 and 100 and 10 into the calculator and press basic current failure intensity
  Then the reliability result should be "3.67879"

@Reliability
Scenario: Expected failures μ(τ)
  Given I have a calculator
  When I have entered 10 and 100 and 10 into the calculator and press basic expected failures
  Then the reliability result should be "63.21206"
