Feature: AddNewRequestType
	This feature in case to create new Request type

Background: User is Logged In
	Given User LogIn Page
	When User enter 'builder2@yopmail.com' and '1234'
	And Click on the SignIn button
	Then Display the Name of current User

@mytag
Scenario: TC-001 Add new request type
	Given User clicks on the left-menu
	And User select the menu Request types
	When User click on the New button
	And User input new Request type
	And User clicks on the DONE button
	Then Display new Request type
