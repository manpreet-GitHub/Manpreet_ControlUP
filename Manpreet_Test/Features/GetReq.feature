Feature: Get request to API

 Simple get Request should be successful 

@tag1
Scenario: Get Request Testing
	Given the user sends a get request with url as "https://rapidapi.com/spamakashrajtech/api/corona-virus-world-and-india-data"
	
	Then request should be a success with 200s code
