using System;

namespace cap2
{
    public class PeriodoDeTempo
    {
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal   { get; set; }

        public bool VerificarSeDataEstaEntrePeriodo(
                DateTime dataParaTestar)
        {
            return dataParaTestar.CompareTo(DataInicial) >= 0
                && dataParaTestar.CompareTo(DataFinal)   <= 0;
        }
    }
}
