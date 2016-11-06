module App.FizzBuzz

let FizzBuzzWithPipeline ruleFactor ruleLabel data = 
    let number, label = data
    match number with
    | n when n % ruleFactor = 0 -> 
        let newLabel = 
            match label with
            | Some l -> l + ruleLabel
            | None -> ruleLabel
        (number, Some newLabel)
    | _ -> data

let ConvertToLabel(number, label) = 
    match label with
    | Some l -> l
    | None -> number.ToString()

let FizzBuzz number = 
    (number, None)
    |> FizzBuzzWithPipeline 3 "Fizz"
    |> FizzBuzzWithPipeline 5 "Buzz"
    |> ConvertToLabel
