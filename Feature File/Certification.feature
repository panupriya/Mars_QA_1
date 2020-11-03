Feature: Certifications
	Add,Edit,Delete for Certifications
	

@Certification
Scenario: Add new Certifications
	Given I login to Website
	When I add new Certifications
	Then I am able to verify that Certifications is added succsfully  


Scenario: Edit Certifications
	Given I login to the website for editing certification
	And  I click in Edit Button for certifications
	When I edit the Certification record and dispaly the alert message
	Then I am able to verify that Certifications edited successfully 



Scenario: Delete Certifications
	Given I go to certification and try to delete it
	Then  I am able to delete certification successfully
	
