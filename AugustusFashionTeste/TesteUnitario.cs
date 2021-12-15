using Microsoft.VisualStudio.TestTools.UnitTesting;
using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using System;
using AugustusFahsion.Model.Venda;

namespace AugustusFashionTeste
{
    [TestClass]
    public class TesteUnitario
    {
        [TestMethod]
        public void se_for_nulo_ou_vazio_retorna_false()
        {
            var nullo = "";
            var resultado = Validacoes.NuloOuVazio(nullo);
            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void se_valor_eh_nulo_ou_vazio_retorna_true()
        {
            string texto = "";
            var resultado = Pessoa.ValorNuloOuVazio(texto);
            Assert.IsTrue(resultado);
        }

        [DataTestMethod]
        [DataRow("2022/10/11", true)]
        [DataRow("2020/11/05", false)]
        public void se_data_nascimento_for_maior_que_hoje_retorna_true(string data, bool resultado)
        {
            var teste = Convert.ToDateTime(data);
            Assert.AreEqual(resultado, Pessoa.DataMaiorQueHoje(teste));
        }

        [DataTestMethod]
        [DataRow("string", false)]
        [DataRow("40028922", true)]
        [DataRow("uhausd12863", false)]
        public void se_conversao_para_inteiro_for_valida_retorna_true(string valor, bool resultado) => Assert.AreEqual(valor.EhNumerico(), resultado);

        [TestMethod]
        public void verifica_se_totalBruto_esta_correto()
        {
            VendaModel venda = new VendaModel();
            venda.ListaDeItens.Add(
                    new VendaProdutoModel()
                    {
                        Quantidade = 2,
                        PrecoVenda = 1.5m,
                    }
                );
            venda.ListaDeItens.Add(
                    new VendaProdutoModel()
                    {
                        Quantidade = 1,
                        PrecoVenda = 2.5m,
                    }
                );

            var resultado = venda.TotalBruto.RetornarValor;
            decimal resultadoEsperado = 5.5m;

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void verifica_se_totalLiquido_esta_correto()
        {
            VendaModel venda = new VendaModel();
            venda.ListaDeItens.Add(
                    new VendaProdutoModel()
                    {
                        TotalLiquido = 21.3m
                    }
                );
            venda.ListaDeItens.Add(
                    new VendaProdutoModel()
                    {
                        TotalLiquido = 1
                    }
                );

            var resultado = venda.TotalLiquido.RetornarValor;
            decimal resultadoEsperado = 22.3m;

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void verifica_se_totalDesconto_esta_correto()
        {
            VendaModel venda = new VendaModel();
            venda.ListaDeItens.Add(
                    new VendaProdutoModel()
                    {
                        Quantidade = 1,
                        TotalBruto = 4,
                        PrecoVenda = 4,
                        TotalLiquido = 2
                    }
                );
            venda.ListaDeItens.Add(
                    new VendaProdutoModel()
                    {
                        Quantidade = 1,
                        TotalBruto = 4,
                        PrecoVenda = 4,
                        TotalLiquido = 2,
                    }
                );

            var resultado = venda.TotalDesconto.RetornarValor;
            decimal resultadoEsperado = 4;

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }

}
