module App.Tests

open global.Xunit
open FsUnit.Xunit

[<Fact>]
let ``Sample Test``() =
    App.Class1().X |> should equal "F#"