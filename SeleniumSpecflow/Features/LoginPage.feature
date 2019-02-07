Feature: Login
Test the login functionnality of application 
will verify if the username and password combinaisons are working as expected

@Regressiontest
@Browser:Chrome
Scenario Outline: Verify if the login functionnalitty is working 
	Given I have navigated to the application
	And typed the <username> and <password>
	Then I should see the EA page

Examples: 
| username | password |
| admin    | admin    |
| jimmy    | jimmy    |
