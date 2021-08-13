Feature: Education


@mytag
Scenario:1 Add Seller's Education
	Given  Seller has clicked on  Education tab
	And Seller has clicked on Add New on Education
	And  Seller has added  name of the Colledge
	And Seller has selected country of colledge
	And Seller has selected title
	And Seller has added degree
	And Seller has selected year of graduation
	When seller clicks on Add button on Education
	Then Seller's  education must be saved and visible

	Scenario:2 Edit Seller's Education
	Given  Seller has clicked on  Education tab
	And Seller has clicked on Edit on Education
	And  Seller has edit name of the Colledge
	And Seller has  edit country of colledge
	And Seller has edit title
	And Seller has edit degree
	And Seller has edit year of graduation
	When seller clicks on update button on Education
	Then Seller's  Updated education must be saved and visible

	Scenario:3 Delete Seller's Education
	Given  Seller has clicked on  Education tab
	When seller clicks on delete button on Education
	Then Seller's  education must be deleted