Feature: ProfileCreation
	 As a seller
       I would like to add my profile details
	   so that people seeking for skills can look into my details

 
	

@add, update and delete profile details
Scenario: Add language in the profile details
	Given I login to the website with valid credentials
	When I try to add new language on profile page
	Then Selled should able to add new language successfully

Scenario: Delete new seller language details on profile page
   Given I try to delete existing language
   Then Seller able to delete existing language successfully

Scenario: Add  education details on profile page
	Given I login the website with valid credentials
	When I add education details '<Country>','<Title>','<Year>'
	Then Seller should able to add education details successfully
	Examples:
	| Country | Title  | Year |
	| India   | B.Tech | 2011 |

Scenario: Update the education details
    Given I login to website for updating education details
    When I update the education detail'<Title>'
    Then I should be able to update the education detail successfully
    Examples:
	| Title |
	| M.Tech |