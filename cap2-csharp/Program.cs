﻿using System;
using cap2;

// Acomplamento temporal
// Dependência de ordem

namespace cap2_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // RodarExemploPeriodoDeTempo();
            Console.WriteLine(ExemploUsoDeDeclaracao(2));
            Console.WriteLine(ExemploUsoDeDeclaracao(3));
            Console.WriteLine(ExemploUsoDeDeclaracao(4));
            Console.WriteLine(ExemploUsoDeDeclaracao(5));
        }

        // static void ExemploUsoDeDeclaracao(int numero)
        // {
        //     int resultado = 0; // em algum momento, o valor dessa var pode ser alterado
        //                        // e causar resultados inesperados
        //     bool numeroPar = numero % 2 == 0;
        //     if (numeroPar) resultado = 2; // não fica explícito de nenhuma forma o valor
        //     Console.WriteLine(resultado); // do resultado quando o número não for par
        // }
        
        static int ExemploUsoDeDeclaracao(int numero)
        {
            bool numeroPar = numero % 2 == 0;
            return numeroPar ? 2 : 0;
        }

        static void RodarExemploPeriodoDeTempo()
        {
            PeriodoDeTempo periodo = new PeriodoDeTempo();
            // O que acontece se esquecermos de preencher
            // DataInicial e DataFinal? Comportamento indesejado
            periodo.DataInicial = DateTime.Parse("2020-08-20");
            periodo.DataFinal   = DateTime.Parse("2020-08-31");

            DateTime[] datasParaTeste = new DateTime[]
            {
                DateTime.Parse("2020-08-18"),
                DateTime.Parse("2020-08-22"),
                DateTime.Parse("2020-09-01"),
            };

            foreach (DateTime dataParaTestar in datasParaTeste)
            {
                bool resultadoDaVerificacao = periodo
                    .VerificarSeDataEstaEntrePeriodo(dataParaTestar);
                Console.WriteLine("Data {0}\t= {1}",
                        dataParaTestar.ToString(), resultadoDaVerificacao);
            }
            Console.WriteLine("Depois da alteração");

            periodo.DataFinal = DateTime.MaxValue;
            Console.WriteLine("periodo.DataFinal\t= {0}",
                    periodo.DataFinal);
            foreach (DateTime dataParaTestar in datasParaTeste)
            {
                bool resultadoDaVerificacao = periodo
                    .VerificarSeDataEstaEntrePeriodo(dataParaTestar);
                Console.WriteLine("Data {0}\t= {1}",
                        dataParaTestar.ToString(), resultadoDaVerificacao);
            }

            Console.WriteLine("PeriodoDeTempoImutavel");
            PeriodoDeTempoImutavel periodoImutavel = new PeriodoDeTempoImutavel(
                    DateTime.Parse("2020-08-20")
                    , DateTime.Parse("2020-08-31"));

            foreach (DateTime dataParaTestar in datasParaTeste)
            {
                bool resultadoDaVerificacao = PeriodoDeTempoImutavel
                    .VerificarSeDataEstaEntrePeriodo(periodoImutavel, dataParaTestar);
                Console.WriteLine("Data {0}\t= {1}",
                        dataParaTestar.ToString(), resultadoDaVerificacao);
            }

            Console.WriteLine("Depois da alteração");
            PeriodoDeTempoImutavel novoPeriodoImutavel = PeriodoDeTempoImutavel
                .AdicionarDias(periodoImutavel, 3);
            foreach (DateTime dataParaTestar in datasParaTeste)
            {
                bool resultadoDaVerificacao = PeriodoDeTempoImutavel
                    .VerificarSeDataEstaEntrePeriodo(periodoImutavel, dataParaTestar);
                Console.WriteLine("Data {0}\t= {1}",
                        dataParaTestar.ToString(), resultadoDaVerificacao);
            }
        }
    }
}
