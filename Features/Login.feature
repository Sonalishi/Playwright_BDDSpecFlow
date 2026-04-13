Feature: Login Scenarios


@smoke @Regression 
Scenario: Successful login with valid username and password
  Given the user is on the login page
  When the user enters a valid username "<username>"
  And the user enters a valid password "<password>"
  And the user clicks the "Login" button
  Then the user should be redirected to the dashboard
Examples:
  | username       | password     |
  | Admin | admin123|
  

