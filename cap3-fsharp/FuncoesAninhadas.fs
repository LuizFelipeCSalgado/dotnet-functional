module FuncoesAninhadas

let escreveSeNumeroEhParOuImpar numero =
  let verificaSeONumeroEhPar = numero % 2 = 0
  let escreveNumeroPar () = printfn "O número %d é par" numero
  let escreveNumeroImpar () = printfn "O número %d é impar" numero
  if verificaSeONumeroEhPar then escreveNumeroPar()
  else escreveNumeroImpar()

