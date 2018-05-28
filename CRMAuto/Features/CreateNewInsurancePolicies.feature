Feature: CreateNewInsurancePolicies
	This feature will test in case create success a new Insurance policies

Background: User is Logged In
	Given User LogIn Page
	When User enter 'builder1@yopmail.com' and '1234'
	And Click on the SignIn button
	Then Display the Name of current User

@mytag
Scenario: TC-002 Create New Insurance Policies
	Given User clicks on the left-menu
	And User select the menu Insurance policies
	When User Navigate to the modal New Insurance policies
	And User input new Insurance policies
	And User clicks on the DONE button
	Then Display new Insurance policies
	
