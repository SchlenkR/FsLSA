
# FsLSA

FsLSA is a library that provides polymorphic and unqualified access to common functions of List, Seq and Array.

```fsharp
#r "FsLSA.dll"
open FsLSA

let add1 = (+) 1

[ 1; 2; 3 ]
|> map add1
|> reduce (+)

[| 1; 2; 3 |]
|> map add1
|> reduce (+)

seq { yield 1; yield 2; yield 3 }
|> map add1
|> reduce (+)
```

## Current Status

Initial and completely untested.

## A Word on Unqualified Access

For good reasons, the F# Core modules for List, Seq, and Array require qualified access, and it is best practice to use them in production code instead of FsLSA.
