using AugustusFahsion.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AugustusFashionTeste.Model
{
    [TestClass]
    public class PessoaModelTeste
    {
        [DataTestMethod]
        [DataRow("2022/10/11", true)]
        [DataRow("2020/11/05", false)]
        public void se_data_nascimento_for_maior_que_hoje_retorna_true(string data, bool resultado)
        {
            var teste = Convert.ToDateTime(data);
            Assert.AreEqual(resultado, Pessoa.DataMaiorQueHoje(teste));
        }
    }
}
