using Microsoft.VisualStudio.TestTools.UnitTesting;
using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using System;

namespace AugustusFashionTeste
{
    [TestClass]
    public class UnitTest1
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

        [TestMethod]
        public void se_data_nascimento_for_maior_ou_igual_a_hoje()
        {
            //var dataNascimento = DateTime.Now;
            //var resultado = Pessoa.
        }

    }
}
