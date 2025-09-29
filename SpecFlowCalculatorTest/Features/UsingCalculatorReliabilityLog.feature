Feature: UsingCalculatorReliabilityLog
  In order to plan testing and release readiness
  As a reliability engineer
  I want to compute log-model failure intensity and expected failures

  @Reliability
  Scenario: Current failure intensity from log model
    Given I have a calculator
    When I have entered 10 and 0.02 and 50 into the calculator and press log current failure intensity
    Then the reliability result should be "3.67879"  # 10 * exp(-0.02*50)

  @Reliability
   Scenario: Expected failures after 10 CPU hours (log model)
    Given I have a calculator
    When I have entered 10 and 0.02 and 10 into the calculator and press log expected failures
    Then the reliability result should be "54.9306"  # (1/θ)*ln(1+λ0*θ*τ)

  @Reliability
  Scenario: Expected failures after 100 CPU hours (log model)
    Given I have a calculator
    When I have entered 10 and 0.02 and 100 into the calculator and press log expected failures
    Then the reliability result should be "152.226"  # matches slide order-of-magnitude
