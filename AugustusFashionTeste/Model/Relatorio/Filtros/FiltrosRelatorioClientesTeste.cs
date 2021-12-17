using AugustusFahsion.Model.Relatorio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AugustusFashionTeste.Model.Relatorio.Filtros
{
    [TestClass]
    class FiltrosRelatorioClientesTeste
    {
        [DataTestMethod]
        [DataRow(1, "SELECT TOP 1")]
        [DataRow(0, "SELECT ")]
        public static void verifica_se_geracao_de_filtros_select_esta_correta(int quantidadeClientes, string resultadoEsperado) 
        {
            FiltrosRelatorioClientes filtros = new FiltrosRelatorioClientes();
            filtros.QuantidadeDeClientes = quantidadeClientes;

            var resultado = filtros.GerarFiltrosSelect();

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [DataTestMethod]
        [DataRow(1, " ")]
        public static void verifica_se_geracao_de_filtros_where_esta_correta() 
        {
            var resultado = filtros.();
        }

    }
}
