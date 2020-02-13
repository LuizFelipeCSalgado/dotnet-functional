using System;
using System.Collections.Generic;
using System.Linq;
using static FuncoesDeEscritaNS.FuncoesDeEscrita;
using static Verificador.Verificador;

namespace cap3_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // EscreveSeONumeroEhParOuImpar(2);
            Escrever("Luiz");
            ImprimirDobroDosNumeros(Enumerable.Range(1, 10).ToList());
            ImprimirNomes(new List<string>() {
                    "Maggie", "Lisa", "Leo"
                    });
            ImprimirNumeros(Enumerable.Range(1, 10).ToList(), 2);
        }

        static void ImprimirNomes(List<string> nomes) =>
            ExecutarAcaoSobreElementos(nomes, Console.WriteLine);

        static void ImprimirDobroDosNumeros(List<int> numeros) =>
            ExecutarAcaoSobreElementos(numeros,
                    numero => Console.WriteLine(numero * 2));

        // static void MultiplicarEImprimirNumero(int multiplicador, int numero) =>
        //     Console.WriteLine(numero * multiplicador);

        // Action<int> imprimirNumero = (numero) => Console.WriteLine(
        //         numero * multiplicador);
        // return imprimirNumero;
        static Action<int> MultiplicarEImprimirNumero(int multiplicador) =>
            (numero) => Console.WriteLine(numero * multiplicador);

        static void ImprimirNumeros(List<int> numeros, int multiplicador) =>
            ExecutarAcaoSobreElementos(numeros,
                    MultiplicarEImprimirNumero(multiplicador));

        static void ExecutarAcaoSobreElementos<TipoElemento>(
                List<TipoElemento> lista,
                Action<TipoElemento> acao)
        { lista.ForEach(acao); }

        static void ExemploFuncoesDeAltaOrder()
        {
            List<int> numerosPares = new List<int>();
            IEnumerable<int> numeros = Enumerable.Range(0, 10);
            foreach (int numero in numeros)
                if (NumeroEhPar(numero)) numerosPares.Add(numero);

            Console.WriteLine("with foreach");
            foreach (int numero in numerosPares)
                Console.Write("{0} - ", numero);
            Console.WriteLine();

            Console.WriteLine("with Linq.Where(NumeroEhPar)");
            foreach (int numero in numeros.Where(NumeroEhPar))
                Console.Write("{0} - ", numero);
            Console.WriteLine();

            Console.WriteLine("with Linq.Where(lambda)");
            foreach (int numero in numeros.Where(numero => numero % 2 == 0))
                Console.Write("{0} - ", numero);
            Console.WriteLine();
        }

        static void EscreveSeONumeroEhParOuImpar(int numero)
        {
            bool verificaSeONumeroEhPar() => numero % 2 == 0;
            // Func<bool> verificaSeONumeroEhPar = () => numero % 2 == 0;
            void escreveNumeroPar() => Console
                .WriteLine("O número {0} é par", numero);
            void escreveNumeroImpar() => Console
                .WriteLine("O número {0} é ímpar", numero);
            // Action escreveNumeroPar = () => Console
            //     .WriteLine("O número {0} é par", numero);
            // Action escreveNumeroImpar = () => Console
            //     .WriteLine("O número {0} é ímpar", numero);
            if (verificaSeONumeroEhPar()) escreveNumeroPar();
            else escreveNumeroImpar();
        }
    }
}
