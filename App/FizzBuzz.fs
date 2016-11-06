module App.FizzBuzz

let FizzBuzzWithPipeline ruleFactor ruleLabel data = 
    let number, label = data
    match number with
    | n when n % ruleFactor = 0 -> 
        let newLabel = label + ruleLabel
        (number, newLabel)
    | _ -> data

let ConvertToLabel(number, label) = 
    match label with
    | l when l <> "" -> l
    | _ -> number.ToString()

let FizzBuzz number = 
    (number, "")
    |> FizzBuzzWithPipeline 3 "Fizz"
    |> FizzBuzzWithPipeline 5 "Buzz"
    |> ConvertToLabel
