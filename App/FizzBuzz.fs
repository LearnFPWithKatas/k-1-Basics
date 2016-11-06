module App.FizzBuzz

let FizzBuzz number = 
    let mutable printed = false
    let mutable label = ""
    if number % 3 = 0 then
        printed <- true
        label <- label + "Fizz"
    if number % 5 = 0 then 
        printed <- true
        label <- label + "Buzz"
    if printed then label
    else number.ToString()
