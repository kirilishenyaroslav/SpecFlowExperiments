Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@positive
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen


@positive
Scenario Outline: Calculation with two numbers
	Given I have entered <firstValue> into the calculator
	And I have entered <secondValue> into the calculator
	When I press <action>
	Then the <result> should be on the screen

Examples: 
| firstValue | secondValue  | action   | result   |
| 1          | 2            | plus     | 3        |
| 2          | 3            | minus    | -1       |
| 2          | 2            | multiply | 4        |
| 0          | 0            | sin      | 1        |