module App.FizzBuzz

let FizzBuzz number = 
    if number % 3 = 0 then "Fizz"
    else if number % 5 = 0 then "Buzz"
    else number.ToString()
