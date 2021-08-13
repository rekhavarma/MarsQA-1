Feature: Description
	
@mytag
Scenario: Add Seller's Description
    Given  Seller has clicked on Edit Description
	And Seller has added description 
	But Seller's description should not be more than 600 words
	When seller click on save button
	Then Seller's description must be saved and visible