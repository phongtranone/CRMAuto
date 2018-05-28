Feature: LogIn_Feature
	In order to access my account
    As a user of the website
    I want to log into the website

@mytag
Scenario: TC-003  Successful Login with Valid Credentials
	Given User LogIn Page
	When User enter 'builder1@yopmail.com' and '1234'
	And Click on the SignIn button
	Then Display the Name of current User
 
