
#r "../FsLSA/bin/Debug/netstandard2.0/FsLSA.dll"
open FsLSA

let add1 = (+) 1
let isEven x = x % 2 = 0

// it's still int list
[ 1..5 ] |> map add1 |> filter isEven

// it's still int array
[| 1..5 |] |> map add1 |> filter isEven

// it's still int seq
seq { 1..5 } |> map add1 |> filter isEven
