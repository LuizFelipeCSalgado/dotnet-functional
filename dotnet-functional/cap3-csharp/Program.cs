using System;

namespace cap3_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            EscreveSeONumeroEhParOuImpar(2);
            EscreveSeONumeroEhParOuImpar(3);
            EscreveSeONumeroEhParOuImpar(4);
            EscreveSeONumeroEhParOuImpar(5);
            EscreveSeONumeroEhParOuImpar(6);
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
