Feature: UsingCalculatorBasicReliability
	In order to calculate the Basic Musa model's failures/intensities
	As a Software Quality Metric enthusiast
	I want to use my calculator to do this

@CurrentFailureIntensity
Scenario: Calculating failure intensity normally
	Given I have a calculator
	When I have entered "10", "50" and "100" into the calculator and press failure intensity
	Then the failure intensity result should be "5"

@CurrentFailureIntensity
Scenario: Calculating failure intensity with initial failure density of 0
	Given I have a calculator
	When I have entered "0", "50" and "100" into the calculator and press failure intensity
	Then the failure intensity result should be "0"

@CurrentFailureIntensity
Scenario: Calculating failure intensity with 0 failures in infinite time
	Given I have a calculator
	When I have entered "10", "50" and "0" into the calculator and press failure intensity
	Then the failure intensity result should be negative infinity

@CurrentFailureIntensity
Scenario: Calculating failure intensity with 0 average number of failures
	Given I have a calculator
	When I have entered "10", "0" and "100" into the calculator and press failure intensity
	Then the failure intensity result should be "10"

@AverageNumberofExpectedFailures
Scenario: Calculating number of expected failures normally
	Given I have a calculator
	When I have entered "100", "10" and "10" into the calculator and press expected failures
	Then the number of expected failures result should be "63.212055882855765"

@AverageNumberofExpectedFailures
Scenario: Calculating number of expected failures with 0 failures overtime
	Given I have a calculator
	When I have entered "0", "100" and "10" into the calculator and press expected failures
	Then the number of expected failures result should be "0"

@AverageNumberofExpectedFailures
Scenario: Calculating number of expected failures with initial failure density of 0
	Given I have a calculator
	When I have entered "100", "0" and "10" into the calculator and press expected failures
	Then the number of expected failures result should be "0"

@AverageNumberofExpectedFailures
Scenario: Calculating number of expected failures with 0 CPU Hours
	Given I have a calculator
	When I have entered "100", "10" and "0" into the calculator and press expected failures
	Then the number of expected failures result should be "0"