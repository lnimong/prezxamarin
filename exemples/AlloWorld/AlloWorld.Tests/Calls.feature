Feature: Calls
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given I have the following Contacts :
	| name   | number  |
	| Web    | 0123456 |
	| Alm    | 1234567 |
	| Mobile | 2345678 |
	
Scenario Outline: call a contact
	When I select <name>
	Then the dialed number is <number>
Examples: 
	| name   | number  |
	| Web    | 0123456 |
	| Alm    | 1234567 |
	| Mobile | 2345678 |
