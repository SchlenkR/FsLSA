
#r "paket:
nuget Fake.DotNet.Cli
nuget Fake.DotNet.NuGet
nuget Fake.IO.FileSystem
nuget Fake.Core.Target //"

#load ".fake/build.fsx/intellisense.fsx"

open Fake.Core
open Fake.DotNet
open Fake.DotNet.NuGet
open Fake.IO
open Fake.IO.FileSystemOperators
open Fake.IO.Globbing.Operators
open Fake.Core.TargetOperators

#load "./Properties.fsx"

let assertSuccess i = if i <> 0 then failwith "Shell execute was not successful." else ()

let args = Target.getArguments() |> Option.defaultValue [||]

let publish = args |> Array.contains "--publish"
Trace.tracefn "publish is: %b" publish

Target.create "Clean" (fun _ ->
    !! "src/**/bin"
    ++ "src/**/obj"
    ++ ".pack"
    |> Shell.cleanDirs 
)

Target.create "Build" (fun _ ->
    !! "src/**/*.*proj"
    |> Seq.iter (
        DotNet.build (fun opt ->
            { opt with
                Configuration =
                    if publish
                    then DotNet.BuildConfiguration.Release
                    else DotNet.BuildConfiguration.Debug }
    ))
)

Target.create "Pack" (fun _ ->
    !! "src/**/FsLSA*.fsproj"
    |> Seq.iter (fun p ->
        // let packageVersion = { version with (*Patch = 4711u;*) Original = None; PreRelease = PreRelease.TryParse "alpha" }.AsString
        Trace.tracefn "SourceDir is: %s" __SOURCE_DIRECTORY__
        let config = if publish then "Release" else "Debug"
        Shell.Exec ("dotnet", sprintf "pack %s -o %s --no-build -c %s" p (Path.combine __SOURCE_DIRECTORY__ ".pack") config)
        |> assertSuccess
    )
)

// Target.create "Test" (fun _ ->
//     !! "src/**/*Tests.fsproj"
//     |> Seq.iter (fun p ->
//         Shell.Exec ("dotnet", sprintf "test %s --no-build" p) |> assertSuccess)
// )

Target.create "Publish" (fun _ ->
    let nugetApiKey = Environment.environVar Properties.nugetPushEnvVarName
    !! ".pack/*.nupkg"
    |> Seq.iter (fun p ->
        Trace.tracefn "------ pushing: %s" p
        let args = sprintf "nuget push %s -k %s -s %s" p nugetApiKey Properties.nugetServer
        Trace.tracef "exec: dotnet %s" args
        Shell.Exec ("dotnet", args) |> assertSuccess
    )

    // TODO: git tag + release

    // setPackageVersion { packageVersion with (*Patch = 4711u;*) Original = None; PreRelease = PreRelease.TryParse "alpha" }.AsString
    // setPackageVersion { packageVersion with Minor = packageVersion.Minor + 1u; Original = None }.AsString
)

Target.create "final" ignore

"Clean"
    ==> "Build"
    =?> ("Pack", publish)
    =?> ("Publish", publish)
    ==> "final"

Target.runOrDefaultWithArguments "final"
