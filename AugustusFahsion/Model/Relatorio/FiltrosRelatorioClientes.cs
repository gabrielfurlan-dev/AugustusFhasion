using AugustusFahsion.Model.ValueObjects;
using System;

namespace AugustusFahsion.Model.Relatorio
{
    class FiltrosRelatorioClientes
    {
        public string NomeCliente { get; set; }
        public string OrdenarPor { get; set; }
        public decimal TotalLiquidoInicial{ get; set; }
        public int QuantidadeDeClientes { get; set; }
        public DateTime DataInicial{ get; set; }
        public DateTime DataFinal{ get; set; }

        public string GerarFiltrosSelect() 
        {
            var select = @"SELECT ";

            if (QuantidadeDeClientes != 0)
                select = @"SELECT TOP " + QuantidadeDeClientes;

            return select;
        }
        public string GerarFiltrosHaving()
        {
            var having = @" ";

            if (TotalLiquidoInicial != 0)
                having += @" HAVING sum(v.TotalLiquido) > @TotalLiquidoInicial ";

            return having;
        }

        internal string GerarFiltrosOrderBy()
        {
            var orderBy = @" ";

            if (OrdenarPor == "Quantidade")
                orderBy = @" ORDER BY QuantidadeVenda DESC ";
            if (OrdenarPor == "Total  desconto")
                orderBy = @" ORDER BY Desconto DESC ";
            if (OrdenarPor == "Total  liquido (Crescente)")
                orderBy = @" ORDER BY TotalLiquido DESC ";
            if (OrdenarPor == "Total  liquido (Decrescente)")
                orderBy = @" ORDER BY TotalLiquido ";

            return orderBy;
        }
    }
}
