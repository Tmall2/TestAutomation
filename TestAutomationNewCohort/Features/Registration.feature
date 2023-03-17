Feature: Registration

As a user 
in other to benefit from the website
i will need to sign up or do registration

@tag1
Scenario: valid registration
	Given I navigate to the website
	And I click on sign up 
	And I enter username
	And I enter email address
	And I enter password
	When I click on the sign up button
	Then I should be able to register sucessfully
