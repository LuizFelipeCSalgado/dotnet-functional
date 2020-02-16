module Functions

let executarAcaoSobreElementos lista (acao: 'a -> unit) =
    lista |> List.iter acao

// let multiplicarEImprimirNumero multiplicador =
//     let imprimirNumero numero = printfn "%i." (numero * multiplicador)
//     imprimirNumero

let multiplicarEImprimirNumero multiplicador numero =
    printfn "%i." (numero * multiplicador)

let imprimirListaDeNumeros multiplicador numeros =
    executarAcaoSobreElementos numeros (multiplicarEImprimirNumero multiplicador)
