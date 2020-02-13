// Learn more about F# at http://fsharp.org

open System

let escreveSeNumeroEhParOuImpar numero =
  let verificaSeONumeroEhPar = numero % 2 = 0
  let escreveNumeroPar () = printfn "O número %d é par" numero
  let escreveNumeroImpar () = printfn "O número %d é impar" numero
  if verificaSeONumeroEhPar then escreveNumeroPar()
  else escreveNumeroImpar()

[<EntryPoint>]
let main argv =
    escreveSeNumeroEhParOuImpar 2
    escreveSeNumeroEhParOuImpar 3
    escreveSeNumeroEhParOuImpar 4
    escreveSeNumeroEhParOuImpar 5
    0 // return an integer exit code
