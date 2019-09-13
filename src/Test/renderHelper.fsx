

let excludedMethods = [ 
    "GetHashCode"
    "ToString"
    "Equals"
    "Singleton"
    "Unfold"
    "ScanBack"
    "Replicate"
    "MapFoldBack"
    "FoldBack"
    "FoldBack2"
]

let nameMap = [
    "MapIndexed", "Mapi"
    "MapIndexed2", "Mapi2"
    "Reverse", "Rev"
    "Iterate", "Iter"
    "Iterate2", "Iter2"
    "IterateIndexed", "Iteri"
    "IterateIndexed2", "Iteri2"
    "ForAll", "Forall"
    "ForAll2", "Forall2"
]

let typeMap = [
    "List", "list"
    "Seq", "source"
    "Array", "array" 
]

open System
open System.Linq

let commonFunctions =

    let assemblies = 
        AppDomain.CurrentDomain.GetAssemblies()
        |> Seq.collect (fun asm -> try asm.ExportedTypes with _ -> Enumerable.Empty<Type>())
    
    let mapName s =
        nameMap
        |> List.filter (fun (k,v) -> k = s)
        |> List.tryHead
        |> Option.defaultValue ("",s)
        |> fun (_,v) -> v

    let getModuleMethods (name, propertyPrefix) =
        assemblies
        |> Seq.filter (fun t -> t.Name = name + "Module")
        |> Seq.head
        |> fun t -> t.GetMethods()
        |> Array.filter (fun m -> List.contains m.Name excludedMethods |> not)
        |> Array.map (fun m -> mapName m.Name, m.GetParameters())
        |> Array.filter (fun (_,p) -> p.Length > 0)
        |> Array.map (fun (name,p) ->
            name,
            p
            |> Array.map (fun p -> p.Name.Replace(propertyPrefix, "x"))
            |> Array.toList)

    typeMap
    |> List.map (getModuleMethods >> Set.ofArray)
    |> List.reduce Set.intersect
    |> Set.toList
    // |> List.length


(*
    {0} Reduce
    {1} reduce
    {2} x1
    {3} x2 x3     OR      ()
    {4} x1 x2 x3
    {5} x3 x2 x1
*)
let template = """
type {0} = {0} with
    static member inline ($) ({0}, {2}) = fun {3} -> Seq.{1} {4}
    static member inline ($) ({0}, {2}) = fun {3} -> List.{1} {4}
    static member inline ($) ({0}, {2}) = fun {3} -> Array.{1} {4}
let inline {1} {4} = (($) {0}) {5}
"""

let toLowerCamelCase (s:string) =
    let chars = s.ToCharArray()
    String(chars.[1..] |> Array.append [| Char.ToLower(chars.[0]) |])

// [
//     "Reduce", ["f"; "x"]
//     "Filter", ["f"; "x"]
// ]
commonFunctions
|> List.map (fun (name,args) ->
    let revArgs = args |> List.rev
    let typeName = name
    let functionName = toLowerCamelCase name
    let firstArg = revArgs.Head
    let anonFunctionParams =
        match revArgs |> List.tail |> String.concat " " with
        | "" -> "()"
        | s -> s
    String.Format(
        template,
        typeName,
        functionName,
        firstArg,
        anonFunctionParams,
        args |> String.concat " ",
        revArgs |> String.concat " "))
|> List.reduce (fun a b -> a + "\n" + b)
|> printfn "%s"
