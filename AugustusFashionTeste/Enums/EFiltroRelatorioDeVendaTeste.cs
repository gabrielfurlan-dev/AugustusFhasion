using Microsoft.VisualStudio.TestTools.UnitTesting;
using AugustusFahsion.Enums;
using AugustusFahsion.Model.Relatorio;

namespace AugustusFashionTeste.Model
{
    [TestClass]
    public class EFiltroRelatorioDeVendaTeste
    {
        //[TestMethod]
        //public void verificar_se_descricao_do_enum_padrao_esta_correta()
        //{
        //    EFiltroRelatorioDeVenda FiltrarPor = (EFiltroRelatorioDeVenda)-1;

        //    var resultado = FiltrosRelatorioClientes.GetEnumDescription(FiltrarPor);
        //    string resultadoEsperado = " sum(v.TotalLiquido) ";

        //    Assert.AreEqual(resultado, resultadoEsperado);
        //}

        [TestMethod]
        public void verificar_se_descricao_do_enum_quantidade_esta_correta()
        {
            EFiltroRelatorioDeVenda FiltrarPor = 0;

            var resultado = FiltrosRelatorioClientes.GetEnumDescription(FiltrarPor);
            string resultadoEsperado = " count(v.IdVenda) ";

            Assert.AreEqual(resultado, resultadoEsperado);
        }

        [TestMethod]
        public void verificar_se_descricao_do_enum_totalDesconto_esta_correta() 
        {
            EFiltroRelatorioDeVenda FiltrarPor = (EFiltroRelatorioDeVenda)1;

            var resultado = FiltrosRelatorioClientes.GetEnumDescription(FiltrarPor);
            string resultadoEsperado = " sum(v.TotalDesconto) ";

            Assert.AreEqual(resultado, resultadoEsperado);
        }

        [TestMethod]
        public void verificar_se_descricao_do_enum_totalLiquido_esta_correta()
        {
            EFiltroRelatorioDeVenda FiltrarPor = (EFiltroRelatorioDeVenda)2;

            var resultado = FiltrosRelatorioClientes.GetEnumDescription(FiltrarPor);
            string resultadoEsperado = " sum(v.TotalLiquido) ";

            Assert.AreEqual(resultado, resultadoEsperado);
        }

    }
}

