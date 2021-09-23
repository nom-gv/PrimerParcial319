// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System

[<EntryPoint>]
let main argv = 
    
    let primero = 2
    let segundo = 10

    //PRIMERA FORMA
    let sumassuc = Seq.init segundo (fun n -> (n * primero)+primero) 
    let ult = Seq.last sumassuc

    //SEGUNDA FORMA
    let mutable ultimo = 0
    for n in 1..segundo do
        ultimo <- ultimo + primero
        printfn "%i+%i=%i" primero n ultimo

    printfn "Multiplicacion de %i*%i = %i" primero segundo ultimo


    Console.ReadKey() |> ignore
    0 // return an integer exit code
