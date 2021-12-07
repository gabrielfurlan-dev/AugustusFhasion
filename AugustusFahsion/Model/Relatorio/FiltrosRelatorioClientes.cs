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
                select += @" TOP @QuantidadeDeClientes";
            return select;
        }
        public string GerarFiltrosWhere()
        {
            var where = @" WHERE pe.NOME LIKE @NomeCliente + '%' AND v.DataVenda BETWEEN @DataInicial AND @DataFinal  + ' 23:59' ";

            if ( TotalLiquidoInicial != 0)
                where += @" AND TotalLiquido > @TotalLiquidoInicial ";

            return where;
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
