// Learn more about F# at http://fsharp.org

open System

let ehImpar valor = not <| (valor % 2 = 0)

let converterBoolParaTexto valorBool =
    if valorBool
        then "Sim"
        else "Não"

// "COMPOSIÇÃO MANUAL"
// let verificarSeEhImpar valor =
//     let resultado = ehImpar valor
//     converterBoolParaTexto resultado

let compor funcao1   funcao2   parametro = funcao2   (funcao1   (parametro))
        // 'a -> 'b  'b -> 'c  'a          'b -> 'c   'a -> 'b   'a
        // 'a -> 'c

// pode-se omitir o parâmetro tipo 'a de ehImpar ("valor")
let verificarSeEhImpar =
    compor ehImpar converterBoolParaTexto

let verificarSeEhImparComposicao = ehImpar >> converterBoolParaTexto
// let verificarSeEhImparPipe = ehImpar |> converterBoolParaTexto
// falha porque ehImpar é do tipo int -> bool e não bool

let somaEMultiplica = (+)1 >> (*)2
let multiplicaESoma = (+)1 << (*)2

// diferença pipeline e composição
let somaCom10 = (+) 10
let somarNumeroCom10 = 3 |> somaCom10
// let somarNumeroCom10Composicao = 3 >> somaCom10 // falha porque 3 não é função

[<EntryPoint>]
let main argv =
    printfn "2 é ímpar? %s" (verificarSeEhImpar 2)
    printfn "3 é ímpar? %s" (verificarSeEhImpar 3)

    printfn "2 é ímpar? %s" (verificarSeEhImparComposicao 2)
    printfn "3 é ímpar? %s" (verificarSeEhImparComposicao 3)

    printfn "resultado somaEMultiplica 5 = %i" (somaEMultiplica 5)
    printfn "resultado multiplicaESoma 5 = %i" (multiplicaESoma 5)
    0 // return an integer exit code
