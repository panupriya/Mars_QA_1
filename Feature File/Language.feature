Feature: Language
	 As a seller 
	 I would like to Add, Edit and Delete language
@Language

Scenario: Add new Language
	Given I login to website with valid credentials
	When  I try to add new Language on profile page
	Then Seller should able to add new language successfully


Scenario: Update Language
	Given I login to website 
	When  I edit the Language record
	Then Seller should able to edit language successfully



Scenario: Delete Language
	 Given  I click in Delete Button
     Then Seller able to delete language successfully
