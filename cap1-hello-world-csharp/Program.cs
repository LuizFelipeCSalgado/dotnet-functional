using System;
using System.Linq;

namespace cap1
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculadora = new Calculadora();
            int soma = calculadora.SomaQuadradoDosNumerosAteDez();
            Console.WriteLine("soma = {0}", soma);
        }
    }

    class Calculadora
    {
        public int ElevaNumeroAoQuadrado(int numero)
        {
            return numero * numero;
        }

        // public int SomaQuadradoDosNumerosAteDez()
        // {
        //     int soma = 0;
        //     for (int numero = 1; numero <= 10; numero++)
        //         soma += ElevaNumeroAoQuadrado(numero);
        //     return soma;
        // }

        public int SomaQuadradoDosNumerosAteDez()
        {
            return Enumerable.Range(1, 10)
                             .Select(ElevaNumeroAoQuadrado)
                             .Sum();
        }
    }
}
