using Microsoft.VisualStudio.TestTools.UnitTesting;
using AugustusFahsion.Enums;

namespace AugustusFashionTeste.Model
{
    [TestClass]
    public class EFiltroRelatorioDeVendaTeste
    {
        [TestMethod]
        public static void verificar_se_descricao_do_enum_totalDesconto_esta_correta()
        {
            Assert.AreEqual(EFiltroRelatorioDeVenda.TotalDesconto, " sum(v.TotalDesconto) ");
        }
        public static void verificar_se_descricao_do_enum_quantidade_esta_correta()
        {
            Assert.AreEqual(EFiltroRelatorioDeVenda.Quantidade, " count(v.IdVenda) ");
        }
        public static void verificar_se_descricao_do_enum_TotalDesconto_esta_correta()
        {
            Assert.AreEqual(EFiltroRelatorioDeVenda.TotalLiquido, " sum(v.TotalDesconto) ");
        }
        public static void verificar_se_descricao_do_enum_totalLiquido_esta_correta()
        {
            Assert.AreEqual(EFiltroRelatorioDeVenda.Quantidade, " sum(v.TotalLiquido) ");
        }
    }
}

