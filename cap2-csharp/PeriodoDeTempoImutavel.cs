using System;

namespace cap2
{
    public class PeriodoDeTempoImutavel
    {
        private readonly DateTime _dataInicial;
        public DateTime DataInicial { get { return _dataInicial; } }
        private readonly DateTime _dataFinal;
        public DateTime DataFinal   { get { return _dataFinal; } }

        public PeriodoDeTempoImutavel(DateTime dataInicial,
                                      DateTime dataFinal)
        {
            _dataInicial = dataInicial;
            _dataFinal   = dataFinal;
        }

        public static bool VerificarSeDataEstaEntrePeriodo(
                PeriodoDeTempoImutavel periodo, DateTime dataParaTestar)
        {
            return dataParaTestar.CompareTo(periodo.DataInicial) >= 0
                && dataParaTestar.CompareTo(periodo.DataFinal)   <= 0;
        }

        // abordagem imperativa
        // public void AdicionarDias(int dias)
        // {
        //    DataInicial = DataInicial.AddDays(dias); 
        //    DataFinal   = DataFinal.AddDays(dias); 
        // }

        public static PeriodoDeTempoImutavel AdicionarDias(
                PeriodoDeTempoImutavel periodo, int dias)
        {
            return new PeriodoDeTempoImutavel(
                periodo.DataInicial.AddDays(dias),
                periodo.DataFinal.AddDays(dias)
                );
        }
    }
}
