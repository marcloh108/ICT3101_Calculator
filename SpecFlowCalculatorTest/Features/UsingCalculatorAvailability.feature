Feature: UsingCalculatorAvailability
  In order to calculate MTBF and Availability
  As someone who struggles with math
  I want to be able to use my calculator to do this

@Availability
Scenario: Calculating MTBF
  Given I have a calculator
  When I have entered 100 and 10 into the calculator and press MTBF
  Then the availability result should be "110"

@Availability
Scenario: Calculating Availability
  Given I have a calculator
  When I have entered 100 and 10 into the calculator and press Availability
  Then the availability result should be "0.90909"

@Availability
Scenario: Another Availability case
  Given I have a calculator
  When I have entered 50 and 50 into the calculator and press Availability
  Then the availability result should be "0.5"
