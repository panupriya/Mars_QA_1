Feature: Educational details
	
	As a seller
	I would like to add,edit and delete my educational details

@Education
Scenario: Add  education details on profile page
	Given I login to Mars website with valid credentials
	When I add education details as '<Country>','<Title>','<Year>'
	Then Seller should able to add education successfully
	Examples:
	| Country | Title  | Year |
	| India   | B.Tech | 2011 |

Scenario: Update the education details
    Given I login to the website for updating education details
    When I update title in the education detail'<Title>'
    Then I should be able to update the education details successfully
    Examples:
	| Title |
	| M.Tech |

Scenario: Delete Education
	 Given  I click in Delete Education Button
     Then Seller able to delete education successfully
