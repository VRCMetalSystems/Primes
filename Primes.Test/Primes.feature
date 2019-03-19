Feature: Primes
	In order to find prime numbers
	As a Computer Scientist
	I want to be told the prime numbers up to N

@mytag
Scenario: Find the Prime Numbers up to 1
	Given I have entered one as N
	When I execute FindPrimes with value one
	Then the result should be an empty list
