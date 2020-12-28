Feature: Testing Epam web-site


Background: 
    Given I opened Epam web-site

# 1
Scenario: Select language
	Given I click Language select button	
	When I select next region and language:
	     |Ukraine|English|
	Then I should be redirected to Ukrainian region English web-page
# 2
Scenario: Find Job Offers
    Given I am on the main page
	Given I select careers button in menu
	When I enter ".NET" in search field
	Then I should see all job offers related to ".NET"
# 3
Scenario: Apply for job
    Given I am on the page with the list of .NET vacancies
	When I click on "APPLY" button
	Then I should see the page with the job description, candidate'sa responsibilities,requirements,what company offers on the right and an application form on the left
# 4
Scenario: Display office location
	Given I am on the main page
	* I scroll down the page
	* I select office in Belarus
	* I see list of cities in Belarus with EPAM offices
	* I select Minsk city
	When I click "MAP" link
	Then My browser should open new tab with google maps
	And mark the adress of office in Minsk
# 5
Scenario: Connection with Instagram
	Given I am on the main page
	And I scroll to the bottom 
	When I click Instagram button
	Then Browser should redirect me to the EPAM Instagram web page in new tab
# 6 	
Scenario: Using Search tool
	Given I am on the main page
	* I click on the magnifier button
	* Serch menu drops down
	* I type in ".NET" in search field
	When I click "FIND" button
	Then I should see all results of search related to the ".NET"
# 7
Scenario: Adaptive structure
	Given I am on the contact page 
	When I click "CONTACT US" button
	Then browser should onload new page with a contact form
# 8
	Scenario: Change sort criteria
	Given I am on the .NET job offers page
	And by default all offers are sorted by relevance
	And I want to order them by Date
	When I hover my mouse on the "Date" text
	Then cursore form should change into hand with pointing finger to show user that this text is clickable
	# But It doesn't













