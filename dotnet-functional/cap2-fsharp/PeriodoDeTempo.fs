module Cap2
open System

type Periodo = { DataInicial: DateTime; DataFinal: DateTime }

// val adicionarDias: periodo: Periodo -> dias: float -> Periodo
let adicionarDias periodo dias = {
    DataInicial = periodo.DataInicial.AddDays dias
    DataFinal = periodo.DataFinal dias
}

let verificarSeDataEstaEntreOPeriodo (periodo: Periodo) (dataParaTestar: DateTime) =
    dataParaTestar.CompareTo    periodo.DataInicial >= 0
    && dataParaTestar.CompareTo periodo.DataFinal <= 0
