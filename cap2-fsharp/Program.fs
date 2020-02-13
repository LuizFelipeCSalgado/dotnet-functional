open Cap2
open System

[<EntryPoint>]
let main argv =
    let periodo =
        { DataInicial = DateTime.Parse "2019-08-20"
        ; DataFinal   = DateTime.Parse "2019-08-31" }
    let datasParaTeste =
        [|
            DateTime.Parse "2019-08-18"
            DateTime.Parse "2019-08-22"
            DateTime.Parse "2019-09-01"
        |]

    for data in datasParaTeste do
        let dataEstaNoPeriodo = verificarSeDataEstaEntreOPeriodo periodo data
        printfn "%A \t- %b" data dataEstaNoPeriodo

    printfn "periodo = %A" periodo

    for data in datasParaTeste do
        let dataEstaNoPeriodo = verificarSeDataEstaEntreOPeriodo periodo data
        printfn "%A \t- %b" data dataEstaNoPeriodo

    let exemploDeUsoDeExpressao numero =
        let resultado =
            if numero % 2 = 0 then 2 else 0
        printfn "%i" resultado

    exemploDeUsoDeExpressao(4)
    exemploDeUsoDeExpressao(5)
    exemploDeUsoDeExpressao(6)
    exemploDeUsoDeExpressao(7)
    0 // return an integer exit code
