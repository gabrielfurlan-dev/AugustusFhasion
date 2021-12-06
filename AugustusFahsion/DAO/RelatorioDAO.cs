using AugustusFahsion.Model.Relatorio;
using Dapper;
using System;
using System.Collections.Generic;

namespace AugustusFahsion.DAO
{
    public class RelatorioDAO
    {
        internal static List<RelatorioProdutos> Filtrar(FiltrosRelatorioProduto filtros)
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
    }
}
