Feature: CreateUser

Add a User

Scenario: Add a user
	Given I type the name "manpreet"
	And I type the Role "QA"
	Then Validate that the user is created 
