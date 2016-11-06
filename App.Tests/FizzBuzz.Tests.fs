module App.FizzBuzz.Tests

open FsUnit.Xunit
open global.Xunit

[<Fact>]
let ``Number 1 returns string 1`` () = FizzBuzz 1 |> should equal "1"

[<Fact>]
let ``Number 2 returns string 2`` () = FizzBuzz 2 |> should equal "2"
