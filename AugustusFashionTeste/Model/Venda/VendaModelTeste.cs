using Microsoft.VisualStudio.TestTools.UnitTesting;
using AugustusFahsion.Model;
using AugustusFahsion.Model.ValueObjects;

namespace AugustusFashionTeste.Model
{
    [TestClass]
    public class VendaModelTeste
    {
        [TestMethod]
        public void se_valor_limite_for_atingido_retornar_falso()
        {
            var idCliente = 22;
            DinheiroModel TotalLiquido = 20;
            var totalLiquidoOriginal = 0;

            var resultado = new VendaModel().VerificarLimiteGastoCompraAPrazoFoiAtingido
                (
                idCliente, 
                TotalLiquido, 
                totalLiquidoOriginal
                );

            var resultadoEsperado = false;

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void se_valor_limite_nao_for_atingido_retornar_verdadeiro()
        {
            var idCliente = 22;
            DinheiroModel TotalLiquido = 10;
            var totalLiquidoOriginal = 0;

            var resultado = new VendaModel().VerificarLimiteGastoCompraAPrazoFoiAtingido (idCliente, TotalLiquido, totalLiquidoOriginal);
            var resultadoEsperado = true;

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
