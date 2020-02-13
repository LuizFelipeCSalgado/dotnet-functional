namespace Modulos

// Funções necessariamente precisam estar dentre de um módulo
// Namespaces podem conter módulos, mas não o contrário
module FuncoesDeEscrita =
    let escrever nome = printfn "seu nome é: %s" nome

[<RequireQualifiedAccess>]
module FuncoesDeEscritaDeNumeros =
    let escrever idade = printfn "sua idade é: %i" idade
