using Microsoft.VisualStudio.TestTools.UnitTesting;
using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using System;

namespace AugustusFashionTeste
{
    [TestClass]
    public class TesteUnitario
    {
        [TestMethod]
        public void TestMethod1()
        {
            var nullo = "";
            var resultado = Validar.NuloOuVazio(nullo);
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
        [DataRow ("2022/10/11", true)]
        [DataRow("2020/11/05", false)]
        public void se_data_nascimento_for_maior_que_hoje_retorna_true(string data, bool resultado)
        {
            var teste = Convert.ToDateTime(data);
            Assert.AreEqual(resultado, Pessoa.DataMaiorQueHoje(teste));
        }

        [DataTestMethod]
        [DataRow ("string", false)]
        [DataRow ("40028922", true)]
        [DataRow ("uhausd12863", false)]
        public void se_conversao_para_inteiro_for_valida_retorna_true(string valor, bool resultado)
        {
            Assert.AreEqual(valor.EhNumerico(), resultado);
        }

    }
}
