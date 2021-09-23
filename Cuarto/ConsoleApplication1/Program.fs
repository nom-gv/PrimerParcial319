// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
[<EntryPoint>]
let main argv = 

    let lista = [1;4;2;5;1;3;6;8;7;4]
    let impares list = List.filter (fun x -> (x+1) % 2 = 0) list 
    let pares list = List.filter (fun x -> x % 2 = 0) list 
    printfn "Lista de Impares: %A" (impares lista)
    printfn "Lista de Pares: %A" (pares lista)
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code
