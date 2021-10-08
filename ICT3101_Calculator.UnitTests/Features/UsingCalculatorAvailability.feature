Feature: UsingCalculatorAvailability
	In orer to calculate MTBF and Availability
	As someone who struggles with math
	I want to be able to use my calculator to do this

@MTBF 
Scenario: Calculating MTBF
	Given I have a calculator
	When I have entered "200" and "10" into calculator the and press MTBF
	Then the MTBF result should be "210"

@Availability 
Scenario: Calculating Availability
	Given I have a calculator
	When I have entered "200" and "210" into the calculator and press Availability
	Then the availability result should be "0.95238095238095233"

@Availability 
Scenario: Calculating Availability when MTTF is 0
	Given I have a calculator
	When I have entered "0" and "210" into the calculator and press divide
	Then the division result should be "0"

@Availability 
Scenario: Calculating Availability when MTBF is 0
	Given I have a calculator
	When I have entered "200" and "0" into the calculator and press Availability
	Then the availability result should be positive infinity