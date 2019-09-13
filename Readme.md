
# FsLSA

FsLSA is a library that provides polymorphic and unqualified access to common functions of List, Seq and Array.

```fsharp
#r "FsLSA.dll"

open FsLSA

let add1 = (+) 1

[ 1..5 ] |> map add1 |> reduce (+)

[| 1..5 |] |> map add1 |> reduce (+)

seq { 1;2;3 } |> map add1 |> reduce (+)
```

## Current Status

Initial and completely untested.

## A Word on Unqualified Access

For good reasons, the F# Core modules for List, Seq, and Array require qualified access, and it is best practice to use these modules explicitly in production code instead of the FsLSA functions.

## TODO

* Use partially intersected functions instead of fully intersected List, Array, and Seq functions.
* Include Option module (and maybe others).
