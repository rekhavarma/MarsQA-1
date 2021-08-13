Feature: Skills
	
@mytag
Scenario: Add Seller's skills
	Given  Seller has clicked on  Skills tab
	And Seller has clicked on Add New
	And  Seller has added  name of the Skill
	And Seller has chosen Skill level
	When seller clicks on Add button
	Then Seller's Skills must be saved and visible

	Scenario: Edit Skills Added by Seller
	Given  Seller has clicked on  Skills tab
	And Seller has clicked on Edit
	And  Seller has edit  name of the Skills or chosen Skill level
	When seller clicks on Update button
	Then Seller's Skill must be saved and visible

	Scenario: Delete Skill Added by Seller
	Given Seller has clicked on  Skills tab
	When seller clicks on Delete button
	Then Seller's Skill must be Deleted 