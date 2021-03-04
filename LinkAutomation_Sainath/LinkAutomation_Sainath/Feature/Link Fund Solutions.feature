Feature: Link Fund Solutions
	Selecting Jurisdiction

@Jurisdictions
Scenario Outline: Jurisdictions 
When I open the Fund Solutions page 'LinkFund'
Then I can select the <Jurisdiction name> jurisdiction 

Examples: 
       | Jurisdiction name | 
       | United Kingdom    | 
	   | Switzerland       |