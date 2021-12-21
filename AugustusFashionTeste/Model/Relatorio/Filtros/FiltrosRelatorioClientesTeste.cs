 using AugustusFahsion.Enums;
using AugustusFahsion.Model.Relatorio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AugustusFashionTeste.Model.Relatorio.Filtros
{
    [TestClass]
    public class FiltrosRelatorioClientesTeste
    {
        [DataTestMethod]
        [DataRow(1, "SELECT TOP 1")]
        [DataRow(0, "SELECT ")]
        public void verifica_se_geracao_de_filtros_select_esta_correta(int quantidadeClientes, string resultadoEsperado)
        {
            FiltrosRelatorioClientes filtros = new FiltrosRelatorioClientes();
            filtros.QuantidadeDeClientes = quantidadeClientes;

            var resultado = filtros.GerarFiltrosSelect();

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [DataTestMethod]
        [DataRow(0, " HAVING  count(v.IdVenda)  > @APartirDe ")]
        [DataRow(1, " HAVING  sum(v.TotalDesconto)  > @APartirDe ")]
        [DataRow(2, " HAVING  sum(v.TotalLiquido)  > @APartirDe ")]
        public void verifica_se_geracao_de_filtros_having_esta_correta(int filtrarPor, string resultadoEsperado)
        {
            FiltrosRelatorioClientes filtros = new FiltrosRelatorioClientes();
            filtros.APartirDe = 1;
            filtros.FiltrarPor = (EFiltroRelatorioDeVenda)filtrarPor;

            var resultado = filtros.GerarFiltrosHaving();

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [DataTestMethod]
        [DataRow(0, " ORDER BY QuantidadeVenda ")]
        [DataRow(1, " ORDER BY Desconto ")]
        [DataRow(2, " ORDER BY TotalLiquido")]
        public void verifica_se_geracao_de_filtros_orderBy_esta_correta(int ordenarPor, string resultadoEsperado)
        {
            FiltrosRelatorioClientes filtros = new FiltrosRelatorioClientes();
            filtros.OrdenarPor = (EOrdemRelatorioDeVenda)ordenarPor;

            var resultado = filtros.GerarFiltrosOrderBy();

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [DataTestMethod]
        [DataRow("Decrescente", " DESC ")]
        [DataRow("Crescente", " ")]
        public void verifica_se_geracao_de_filtros_DirecaoOrdem_esta_correta(string direcaoOrdem, string resultadoEsperado)
        {
            FiltrosRelatorioClientes filtros = new FiltrosRelatorioClientes();
            filtros.DirecaoOrdem = direcaoOrdem;

            var resultado = filtros.GerarDirecaoDaOrdem();

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [DataTestMethod]
        [DataRow(0, " WHERE ")]
        [DataRow(1, " WHERE c.IdCliente = @IdCliente AND ")]
        public void verifica_se_geracao_de_filtros_where_esta_correta(int idCliente, string resultadoEsperado)
        {
            FiltrosRelatorioClientes filtros = new FiltrosRelatorioClientes();
            filtros.IdCliente = idCliente;

            var resultado = filtros.GerarFiltrosWhere();

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
