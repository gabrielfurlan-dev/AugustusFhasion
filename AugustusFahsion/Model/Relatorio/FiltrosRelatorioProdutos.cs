using System;

namespace AugustusFahsion.Model.Relatorio
{
    class FiltrosRelatorioProdutos
    {
        public int IdCliente { get; set; }
        public string NomeProduto { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }

        public string GerarFiltrosWhere()
        {
            var where = " WHERE v.DataVenda BETWEEN @DataInicial AND @DataFinal  + ' 23:59' AND v.Condicao = 'Ativa' ";

            if (IdCliente != 0)
                where += " AND v.IdCliente = @IdCliente ";

            return where;
        }

        internal string GerarFiltrosHaving()
        {
            var having = " HAVING p.Nome LIKE @NomeProduto + '%' ";

            if(String.IsNullOrEmpty(NomeProduto))
                having = "";

            return having;
        }
    }
}
