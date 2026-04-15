Feature: Dashboard Scenarios

Background: Login to the application
	Given the user is on the login page
  When the user enters a valid username "Admin"
  And the user enters a valid password "admin123"
  And the user clicks the "Login" button


@smoke @Regression
Scenario: Verify dashboard Menu navigates to the correct page
	Given the user is on Dashboard page
	When the user click on "<Menu>" option
	Then the user should navigate to "<Menu>" page
	Examples:
  | Menu   |
  | Admin |
  | PIM |
  | Leave |
  | Claim |
  | Recruitment |
	