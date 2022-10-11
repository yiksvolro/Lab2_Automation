Feature: AddCustomer
	Add a simple customer

@smoke
Scenario: Perform adding a simple customer
	Given I launch the application
	And I click on the Bank Manager Login link
	And I click on AddCustomer button
	And I enter the information
	When I click on create
	Then I should see success alert
