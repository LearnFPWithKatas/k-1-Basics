module App.FizzBuzz

let FizzBuzzWithPipeline ruleFactor ruleLabel data = 
    let number, label = data
    if number % ruleFactor = 0 then 
        let newLabel = label + ruleLabel
        (number, newLabel)
    else data

let ConvertToLabel(number, label) = 
    if label <> "" then label
    else number.ToString()

let FizzBuzz number = 
    (number, "")
    |> FizzBuzzWithPipeline 3 "Fizz"
    |> FizzBuzzWithPipeline 5 "Buzz"
    |> ConvertToLabel
