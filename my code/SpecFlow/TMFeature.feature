Feature: TMFeature

As a TurnUp portal admin
i would like to create,edit and delete time and material records
so that I can manage employee's time and material successfully


Scenario: create time and material record with valid data
	Given I logged into TurnUp portal successfully
	And  I navigate to time and material page
	When I create time and material record
	Then the record should be created sucessfully

Scenario Outline: edit time and material record with valid data 
	Given I logged into TurnUp portal successfully
	And  I navigate to time and material page
	When I update '<Description>' on an existing time and material record
	Then the record should have the updated '<Description>'


	Examples: 
	| Description |
	| my code     |
	| Dog         |
	| keyboard     |



