Feature: Login Scenarios


@smoke @Regression 
Scenario: Successful login with valid username and password
  Given the user is on the login page
  When the user enters a valid username "<username>"
  And the user enters a valid password "<password>"
  And the user clicks the "Login" button
  Then the user should be redirected to the homepage/dashboard
Examples:
  | username       | password     |
  | john.doe@email.com | Password123! |
  | testuser123    | Test@456     |

  @smoke
  Scenario: Login fails with invalid password
  Given the user is on the login page
  When the user enters a valid username "john.doe@email.com"
  And the user enters an incorrect password "WrongPass123!"
  And the user clicks the "Login" button
  Then the user should see an error message "Invalid username or password"
  And the user should remain on the login page

  @smoke
  Scenario: Login fails with non-existent username
  Given the user is on the login page
  When the user enters a non-existent username "unknown.user@fake.com"
  And the user enters any password "Password123!"
  And the user clicks the "Login" button
  Then the user should see an error message "Invalid username or password"
  And the user should remain on the login page