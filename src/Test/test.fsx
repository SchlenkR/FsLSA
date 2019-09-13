
#r "../FsLSA/bin/Debug/netstandard2.0/FsLSA.dll"
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

(* TODO:
collect
append
choose
*)

[| 1; 2; 3 |]
|> Array.map ( (+) 1)
|> Array.reduce (+)
