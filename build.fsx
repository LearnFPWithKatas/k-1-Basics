#r "./packages/FAKE/tools/FakeLib.dll"

open Fake
open Fake.Testing

let buildDir = @".\build\"
let testDir = @".\build\"

Target "Clean" (fun _ -> CleanDirs [ buildDir ])

Target "Rebuild" DoNothing

Target "Build" (fun _ -> 
    !!"*.sln"
    |> MSBuild buildDir "Build" [ "Configuration", "Release"
                                  "Platform", "Any CPU" ]
    |> ignore)

let runTest pattern = 
    fun _ -> 
        !!(buildDir + pattern) 
        |> xUnit (fun p -> 
                  { p with 
                        ToolPath = findToolInSubPath "xunit.console.exe" (currentDirectory @@ "tools" @@ "xUnit")
                        WorkingDir = Some testDir })

Target "Test" DoNothing

Target "UnitTests" (runTest "/*.Tests*.dll")

"Clean" ?=> "Build"
"Clean" ==> "Rebuild"
"Build" ==> "Rebuild"
"Build" ?=> "UnitTests" ==> "Test"
"Rebuild" ==> "Test"

RunTargetOrDefault "Test"
