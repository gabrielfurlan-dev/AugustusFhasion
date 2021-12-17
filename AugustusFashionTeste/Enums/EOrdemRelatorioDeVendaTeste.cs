using AugustusFahsion.Enums;
using AugustusFahsion.Model.Relatorio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AugustusFashionTeste.Model.Relatorio.Filtros
{
    [TestClass]
    class EOrdemRelatorioDeVendaTeste
    {
        //[TestMethod]
        //public static void verifica_se_descricao_do_enum_padrao_esta_correto() 
        //{
        //    EOrdemRelatorioDeVenda OrdenarPor = (EOrdemRelatorioDeVenda)-1;
        //    var resultado = FiltrosRelatorioClientes.GetEnumDescription(OrdenarPor);
        //    var resultadoEsperado = " ";

        //    Assert.AreEqual(resultadoEsperado, resultado);
        //}

        [TestMethod]
        public static void verifica_se_descricao_do_enum_quantidade_esta_correto()
        {
            EOrdemRelatorioDeVenda OrdenarPor = (EOrdemRelatorioDeVenda) 0;
            var resultado = FiltrosRelatorioClientes.GetEnumDescription(OrdenarPor);
            var resultadoEsperado = " ORDER BY QuantidadeVenda ";

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public static void verifica_se_descricao_do_enum_totalDesconto_esta_correto()
        {
            EOrdemRelatorioDeVenda OrdenarPor = (EOrdemRelatorioDeVenda)1;
            var resultado = FiltrosRelatorioClientes.GetEnumDescription(OrdenarPor);
            var resultadoEsperado = " ORDER BY Desconto ";

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public static void verifica_se_descricao_do_enum_totalLiquido_esta_correto()
        {
            EOrdemRelatorioDeVenda OrdenarPor = (EOrdemRelatorioDeVenda)2;
            var resultado = FiltrosRelatorioClientes.GetEnumDescription(OrdenarPor);
            var resultadoEsperado = " ORDER BY TotalLiquido";

            Assert.AreEqual(resultadoEsperado, resultado);
        }

    }
}
