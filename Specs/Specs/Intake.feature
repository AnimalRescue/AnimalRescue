Feature: Intake

Scenario: User must be authorized to perform intake
	Given The user is logged in
	And The user has intake permission
	When The user attempts to perform intake
	Then the intake screen should be displayed

Scenario: User must specify animal type during Intake
	Given the user is an authorized to perform intake
	When a new animal is taken into the rescue
	Then the animal's type must be recorded from a pre-populated list


@ignore
Scenario: User is not authorized to perform intake
	Given The user is logged in
	And The user does not have intake permission
	When The user attempts to perform intake
	Then A user-not-authorized error message should be displayed

@ignore
Scenario: Animal type is not selected
	Given The user is authorized
	And The user is at the intake screen
	When The user has not selected an animal type
	Then The screen cannot be submitted

@ignore
Scenario: Animal type is selected
	Given The user is authorized
	And The user is at the intake screen
	When The user has selected an animal type
	Then The screen can be submitted