using AugustusFahsion.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AugustusFashionTeste.Model
{
    [TestClass]
    public class ProdutoModelTeste
    {

        [TestMethod]
        public void verificar_se_total_bruto_do_produto_selecionado_esta_correto()
        {
            var precoVenda = 2.5m;
            int quantidade = 2;

            var resultado = ProdutoModel.ValorTotalBrutoProduto(precoVenda, quantidade);
            var resultadoEsperado = 5;

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void verificar_se_desconto_em_porcentagem_para_reais_esta_correto()
        {
            decimal valorTotalBruto = 10m;
            int desconto = 10;

            var resultado = ProdutoModel.DescontoPorcentagemEmDecimal(valorTotalBruto, desconto);
            var resultadoEsperado = 1;

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void verificar_se_valor_total_do_desconto_esta_correto() 
        {

            decimal precoVenda = 10;
            int quantidade = 2;
            int desconto = 10;

            var resultado = ProdutoModel.ValorTotalDesconto(precoVenda, quantidade, desconto);
            var resultadoEsperado = 18;

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void verificar_se_total_desconto_do_protudo_esta_correto() 
        {
            int desconto = 10;
            int quantidade = 2;
            int precoProduto = 10;

            var resultado = ProdutoModel.ValorTotalDescontoProduto(desconto, quantidade, precoProduto);
            var resultadoEsperado = 2;

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]

        public void verificar_se_valor_do_lucro_do_produto_esta_correto() 
        {
            var produtoLucroUnitario = 10;
            int quantidade = 2;

            int desconto = 10;
            decimal precoProduto = 20;

            var resultado = ProdutoModel.ValorProdutoLucro(produtoLucroUnitario, quantidade, desconto, precoProduto);
            var resultadoEsperado = 16;

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
