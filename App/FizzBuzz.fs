module App.FizzBuzz

let FizzBuzzWithRules rules number = 
    let mutable printed = false
    let mutable label = ""
    for ruleFactor, ruleLabel in rules do
        if number % ruleFactor = 0 then 
            printed <- true
            label <- label + ruleLabel
    if printed then label
    else number.ToString()

let FizzBuzz number = 
    FizzBuzzWithRules [ (3, "Fizz")
                        (5, "Buzz") ] number
