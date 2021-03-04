Feature: Link Group
	Login and Fetch Search Results

@Smoke
Scenario:1 Smoke test
	When I open the home page 'LinkGroup'
	Then the page is displayed
@Search
Scenario:2 Search results
Given I have opened the home page 'LinkGroup'
And I have agreed to the cookie policy 
When I search for 'Leeds' 
Then the search results are displayed