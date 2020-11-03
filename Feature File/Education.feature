Feature: Educational details
	
	As a seller
	I would like to add my educational details

@Education
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