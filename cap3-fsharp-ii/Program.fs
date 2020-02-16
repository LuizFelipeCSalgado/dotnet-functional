// Learn more about F# at http://fsharp.org

open System

let multiplicarEImprimirNumero multiplicador =
    let imprimirNumero numero = printfn "%i." (numero * multiplicador)
    imprimirNumero

// let multiplicarEImprimirNumero multiplicador numero = printfn "%i." (numero * multiplicador)

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
