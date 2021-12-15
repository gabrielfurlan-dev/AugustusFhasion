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
            DinheiroModel TotalLiquido = 20;
            var totalLiquidoOriginal = 0;
            var resultado = VendaModel.VerificarLimiteGastoCompraAPrazoFoiAtingido(22, TotalLiquido, totalLiquidoOriginal);
            var resultadoEsperado = false;

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
