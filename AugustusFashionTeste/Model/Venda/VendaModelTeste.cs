using AugustusFahsion.Model;
using AugustusFashionTeste.Mock;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AugustusFashionTeste.Model
{
    [TestClass]
    public class VendaModelTeste
    {
        [TestMethod]
        public void se_valor_limite_for_atingido_retornar_falso()
        {
            var vendaModel = new VendaModelMock().RetornarListaDeItens();


            vendaModel.Cliente.IdCliente = 22;
            var totalLiquidoOriginal = 0;
            
            var resultado = vendaModel.VerificarLimiteGastoCompraAPrazoFoiAtingido(totalLiquidoOriginal);

            var resultadoEsperado = false;

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void se_valor_limite_nao_for_atingido_retornar_verdadeiro()
        {
            VendaModel vendaModel = new VendaModelMock().RetornarListaDeItens();
            vendaModel.Cliente.IdCliente = 22;
            vendaModel.Cliente.ValorLimiteGasto = 0;

            var totalLiquidoOriginal = 0;

            var resultado = vendaModel.VerificarLimiteGastoCompraAPrazoFoiAtingido(totalLiquidoOriginal);
            var resultadoEsperado = true;

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
