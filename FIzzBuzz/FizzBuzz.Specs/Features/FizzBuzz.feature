Feature: Fizz Buzz

The FizzBuzz game involves saying the word "fizz" when the number is
divisible by 3 and "buzz" when the number is divisible by 5. When the
number can be divided by 3 and 5, you say "fizzbuzz".

There is a fiendish variation of the game called "FizzBuzzFuzz" where numbers
divisible by 7 are also named "fuzz".

Scenario Outline: Fizz Buzz
	Given I am playing FizzBuzz
	When I get to the number in the column named <input>
	Then I should say the answer in the column named <expected>
Examples: 
	| input | expected |
	| 1     | 1        |
	| 2     | 2        |
	| 3     | fizz     |
	| 4     | 4        |
	| 5     | buzz     |
	| 6     | fizz     |
	| 7     | 7        |
	| 8     | 8        |
	| 9     | fizz     |
	| 10    | buzz     |
	| 15    | fizzbuzz |
	| 21    | fizz     |
	| 35    | buzz     |
	| 105   | fizzbuzz |

Scenario Outline: Fizz Buzz Fuzz
	Given I am playing FizzBuzzFuzz
	When I get to the number in the column named <input>
	Then I should say the answer in the column named <expected>
Examples: 
	| input | expected     |
	| 1     | 1            |
	| 2     | 2            |
	| 3     | fizz         |
	| 4     | 4            |
	| 5     | buzz         |
	| 6     | fizz         |
	| 7     | fuzz         |
	| 8     | 8            |
	| 9     | fizz         |
	| 10    | buzz         |
	| 15    | fizzbuzz     |
	| 21    | fizzfuzz     |
	| 35    | buzzfuzz     |
	| 105   | fizzbuzzfuzz |
