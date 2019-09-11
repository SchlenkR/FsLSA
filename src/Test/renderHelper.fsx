

open System
open System.Linq

let commonFunctions =
    let assemblies = 
        AppDomain.CurrentDomain.GetAssemblies()
        |> Seq.collect (fun asm -> try asm.ExportedTypes with _ -> Enumerable.Empty<Type>())
    
    let getModuleMethods (name, propertyPrefix) =
        assemblies
        |> Seq.filter (fun t -> t.Name = name + "Module")
        |> Seq.head
        |> fun t -> t.GetMethods()
        // |> Array.map (fun m -> m.Name, m.GetParameters().Length)
        |> Array.map (fun m ->
            m.Name,
            m.GetParameters()
            |> Array.map (fun p -> p.Name.Replace(propertyPrefix, "x"))
            |> Array.toList)

    [
        "List", "list"
        "Seq", "source"
        "Array", "array" 
    ]
    |> List.map (getModuleMethods >> Set.ofArray)
    |> List.reduce Set.intersect
    |> Set.toList
    // |> List.length


(*   {0} Reduce   {1} reduce   {2} f, x   {3} f x   *)
let template = """
type {0} = {0} with
    static member inline (?<-) ({0}, {2}) = Seq.{1} {3}
    static member inline (?<-) ({0}, {2}) = List.{1} {3}
    static member inline (?<-) ({0}, {2}) = Array.{1} {3}
let inline {1} {3} = ((?<-) {0}) {3}
"""

// [
//     "Reduce", ["f"; "x"]
//     "Filter", ["f"; "x"]
// ]
commonFunctions
|> List.map (fun (name,args) ->
    let toLowerCamelCase (s:string) =
        let chars = s.ToCharArray()
        String(chars.[1..] |> Array.append [| Char.ToLower(chars.[0]) |])
    String.Format(
        template,
        name,
        toLowerCamelCase name,
        (String.concat ", " args),
        (String.concat " " args)))
|> List.reduce (fun a b -> a + "\n" + b)
|> printfn "%s"
