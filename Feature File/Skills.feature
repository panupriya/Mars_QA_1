Feature: Skills
	As a seller
	I would like to add,edit and delete my skills
	
@Skills
Scenario: Add new Skills
	Given Login to Mars Portal Skill page
	When I add skills 
	Then I am able to verify that Skills record added sucessfully 


Scenario: Edit Skills
	Given I login to the website
	When I click in Edit Button of skill
	And I edit the Skills record 
	Then I am able to verify that Skills updated sucessfully



Scenario: Delete Skills
	Given I login to the website to dlete skill
	When I try to delete addedes skills
	Then I am able to delete the skill successfully

	
 