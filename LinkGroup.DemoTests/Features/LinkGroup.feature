Feature: LinkGroup
Test on Link Group Home page and checking the Contact Page

Scenario: (1) Smoke test
When I open the home page https://www.linkgroup.com/
Then the page is displayed
 

Scenario: (2) Contact page
Given I have opened the home page
And I have agreed to the cookie policy
When I select Contact
Then the Contact page is displayed