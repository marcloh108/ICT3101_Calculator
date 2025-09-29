Feature: UsingCalculatorFactorial
  In order to compute factorials
  As someone who struggles with math
  I want to use my calculator to do this

@Factorial
Scenario: Normal factorial
  Given I have a calculator
  When I have entered 5 into the calculator and press factorial
  Then the factorial result should be "120"

@Factorial
Scenario: Zero factorial
  Given I have a calculator
  When I have entered 0 into the calculator and press factorial
  Then the factorial result should be "1"

  @Factorial
Scenario: One factorial
  Given I have a calculator
  When I have entered 1 into the calculator and press factorial
  Then the factorial result should be "1"