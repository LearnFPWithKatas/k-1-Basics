module App.FizzBuzz.Tests

open FsUnit.Xunit
open global.Xunit

[<Theory>]
[<InlineData(1, "1")>]
[<InlineData(2, "2")>]
let ``Given number returns expected label`` inputNumber expectedLabel =
    FizzBuzz inputNumber |> should equal expectedLabel
