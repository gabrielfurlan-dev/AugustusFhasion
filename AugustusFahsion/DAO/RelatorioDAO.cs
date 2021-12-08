using AugustusFahsion.Model.Relatorio;
using Dapper;
using System;
using System.Collections.Generic;

namespace AugustusFahsion.DAO
{
    public class RelatorioDAO
    {
        internal static List<RelatorioProdutos> FiltrarRelatorioProdutos(FiltrosRelatorioProdutos filtros)
        {

            var query = @"SELECT p.Nome, sum(vp.Quantidade) AS QuantidadeVendida, Sum(vp.TotalBruto) AS TotalBruto,
                            SUM(vp.TotalBruto - vp.TotalLiquido) AS TotalDesconto, Sum(vp.TotalLiquido)
		                    AS TotalPrecoLiquido, sum(p.PrecoCusto * vp.Quantidade) as TotalCusto,
                            SUM(vp.TotalLiquido - (p.PrecoCusto * vp.Quantidade)) AS TotalLucroReais
                            FROM VendaProduto vp
                            INNER JOIN Produto p on vp.IdProduto = p.IdProduto
                            INNER JOIN Venda v on vp.IdVenda = v.IdVenda ";
                    
            query += filtros.GerarFiltrosWhere();

            query += " GROUP BY p.IdProduto, p.Nome ";

            query += filtros.GerarFiltrosHaving();

            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    var a = conexao.Query<RelatorioProdutos>(query, filtros).AsList();
                    return a;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal static List<RelatorioClientes>FiltrarRelatorioClientes(FiltrosRelatorioClientes filtros)
        {

            var query = filtros.GerarFiltrosSelect();

            query += @" count(v.IdVenda) as QuantidadeVenda, pe.Nome, sum(v.TotalBruto) as TotalBruto,
	                    sum(v.TotalDesconto) as Desconto, sum(v.TotalLiquido) as TotalLiquido
	                    FROM Venda v
	                    INNER JOIN Cliente c on v.IdCliente = c.IdCliente
	                    INNER JOIN Pessoa pe on c.IdPessoa = pe.IdPessoa ";

            query += @" WHERE pe.NOME LIKE @NomeCliente + '%' AND v.DataVenda BETWEEN @DataInicial AND @DataFinal  + ' 23:59' ";

            query += " GROUP BY pe.Nome ";

            query += filtros.GerarFiltrosOrderBy();

            query += filtros.GerarFiltrosHaving();

            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    var a = conexao.Query<RelatorioClientes>(query, filtros).AsList();
                    return a;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
