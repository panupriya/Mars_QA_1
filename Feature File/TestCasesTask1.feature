Feature: TestCasesTask1
	As a Seller
I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details.

@add profile
Scenario: Join as a seller
	Given I Join to the website with valid credential as a seller

Scenario: Sign in as a seller
	Given I signin to the website with valid credentials
	Then I am able to login sucessfully

Scenario: Sign in as a seller with invalid id or passward
    Given I signin to the website with invalid credentials
	Then I am not able to login sucessfully

Scenario: sign in as a seller with valid id and forget passward
     Given I sign in to the website with valid id but forget passward
     When I am able to resetmy passward using code send on email id
	 Then I am able to login sucessfully after resetting passward
	
Scenario: Add profile details as a seller
	Given I signin  to the website with valid credentials
	When I try to add  maximum 4 languages, skills, education details and certificates
	And I add and save share skill details
	Then Seller should able to add all details sucessfully

Scenario: Try to add existing profile details
    Given I signin  to the website with valid credentials
	When I try to add existing language, skill, education and certificate again
	Then I am able to see a warning message and not able to add existing details again

Scenario: Update profile details as a seller
	Given I signin  to the website with valid credentials
	When I try to update language, skill, education and certificate
	And I update and save share skill details
	Then Seller should able to update all details sucessfully 

Scenario: Delete profile details as a seller
	Given I signin  to the website with valid credentials
	When I try to delete language, skill, education and certificate
	Then Seller should able to delete all details sucessfully

Scenario: People seeking for some skills can look into sellers details
	Given Open website 
	When I try to search for skill under category
	Then Seller should able to see the sellers details sucessfully 