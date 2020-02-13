let olaMundo() =
    printfn "Olá mundo!"

let elevaNumeroAoQuadrado numero = numero * numero

let SomaQuadradoDosNumerosAteDez =
    [1..10]
    |> List.map elevaNumeroAoQuadrado
    |> List.sum

[<EntryPoint>]
let main argv =
    System.Console.WriteLine("soma = {0}", SomaQuadradoDosNumerosAteDez)
    olaMundo()
    0 // return an integer exit code
