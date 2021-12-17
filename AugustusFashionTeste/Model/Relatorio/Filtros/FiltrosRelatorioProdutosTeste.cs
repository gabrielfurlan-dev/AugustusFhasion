using AugustusFahsion.Model.Relatorio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AugustusFashionTeste.Model.Relatorio.Filtros
{
    [TestClass]
    public class FiltrosRelatorioProdutosTeste
    {
        [DataTestMethod]
        [DataRow(0, " WHERE v.DataVenda BETWEEN @DataInicial AND @DataFinal  + ' 23:59' AND v.Condicao = 'Ativa' ")]
        [DataRow(1, " WHERE v.DataVenda BETWEEN @DataInicial AND @DataFinal  + ' 23:59' AND v.Condicao = 'Ativa'  AND v.IdCliente = @IdCliente ")]
        public void verifica_se_geracao_de_filtros_where_esta_correta(int idCliente, string resultadoEsperado)
        {
            FiltrosRelatorioProdutos filtros = new FiltrosRelatorioProdutos();
            filtros.IdCliente = idCliente;

            var resultado = filtros.GerarFiltrosWhere();

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [DataTestMethod]
        [DataRow("camista", " HAVING p.Nome LIKE @NomeProduto + '%' ")]
        [DataRow ("", "")]
        [DataRow(null, "")]
        public void verifica_se_geracao_de_filtros_having_esta_correta(string nomeProduto, string resultadoEsperado)
        {
            FiltrosRelatorioProdutos filtros = new FiltrosRelatorioProdutos();
            filtros.NomeProduto = nomeProduto;

            var resultado = filtros.GerarFiltrosHaving();

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
