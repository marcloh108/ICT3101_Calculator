Feature: UsingCalculatorQualityMetrics
  In order to track software quality and size across releases
  As a quality engineer
  I want to compute defect density and current SSI

  @QualityMetrics
  Scenario: Defect density for initial release (from slides)
    Given I have a calculator
    When I have entered 100 and 50 into the calculator and press defect density
    Then the quality metric result should be "2.0"

  @QualityMetrics
  Scenario: Compute current SSI (avoid double counting changed code)
    Given I have a calculator
    When I have entered 50 and 20 and 1 and 4 into the calculator and press current SSI
    Then the quality metric result should be "65"   # 50 + 20 - 1 - 4 = 65 (your slide shows 66 with a different assumption)

  @QualityMetrics
  Scenario: Defect density for second release (from slides)
    Given I have a calculator
    When I have entered 36 and 20 into the calculator and press defect density
    Then the quality metric result should be "1.8"
