using AugustusFahsion.Model.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AugustusFashionTeste.ValueObjects
{
    [TestClass]
    public class DinheiroModelTest
    {
        
        [TestMethod]
        public void validar_se_retorno_do_Dinheiro_model_esta_correto() 
        {
            DinheiroModel resultado = 10;
            decimal RetornarValorEsperado = 10;
            string RetornarValorFormatadoEsperado = "R$ 10,00";

            Assert.AreEqual(RetornarValorEsperado, resultado.RetornarValor);
            Assert.AreEqual(RetornarValorFormatadoEsperado, resultado.ValorFormatado);
        }

    }
}
