Feature: UsingCalculatorFactorial
	Simple calculator for finding the factorial of a single number

@Factorial
Scenario: Factorial of zero
	Given I have a calculator
	When I have entered "0" into the calculator and press factorial
	Then the factorial result should be "1"

@Factorial
Scenario: Factorial of one
	Given I have a calculator
	When I have entered "1" into the calculator and press factorial
	Then the factorial result should be "1"

@Factorial
Scenario: Factorial of positive number
	Given I have a calculator
	When I have entered "3" into the calculator and press factorial
	Then the factorial result should be "6"