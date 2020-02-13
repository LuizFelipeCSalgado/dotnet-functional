// Learn more about F# at http://fsharp.org

open System
open FuncoesAninhadas

let numeroEhPar numero = numero % 2 = 0
let obterNumerosParesDeUmaLista () =
    [0..10]
    |> List.filter numeroEhPar

let executarAcaoSobreElementos lista (acao: 'a -> unit) =
    lista |> List.iter acao

let multiplicarEImprimirNumero multiplicador numero =
    printfn "Dobro de %i é %i" numero (numero * multiplicador)
let imprimirListaDeNumeros multiplicador numeros =
    executarAcaoSobreElementos numeros
        (fun numero -> multiplicarEImprimirNumero multiplicador numero)
let imprimirDobroDeUmNumero numero = printfn "Dobro de %i é %i" numero (2 * numero)
let imprimirNomes nomes = executarAcaoSobreElementos nomes (printfn "Olá %s")
let imprimirDobroDosNumeros numeros =
    // executarAcaoSobreElementos numeros imprimirDobroDeUmNumero
    executarAcaoSobreElementos numeros
        (fun numero -> printfn "Dobro de %i é %i" numero (2 * numero))

// let imprimirNomes nomes =
//    for nome in nomes do printfn "Olá %s!" nome

// let imprimirDobroDosNumeros numeros =
//     for numero in numeros do printfn "%i." (numero * 2)

[<EntryPoint>]
let main argv =
    let nomes = ["Gabriel"; "João"; "José"; "Mariazinha"]
    let numeros = [1..10]
    imprimirNomes nomes
    imprimirDobroDosNumeros numeros
    imprimirListaDeNumeros 2 numeros

    // escreveSeNumeroEhParOuImpar 2
    // for numero in obterNumerosParesDeUmaLista() do
    //     printfn "%i" numero
    0 // return an integer exit code
