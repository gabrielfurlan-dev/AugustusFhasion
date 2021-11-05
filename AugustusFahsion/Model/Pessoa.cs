using AugustusFahsion.Model.Contato;
using AugustusFahsion.Model.Enderecos;
using System;

namespace AugustusFahsion.Model
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Sexo { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public EnderecoModel Endereco { get; set; }
        public ContatoModel Contato { get; set; }

        public Pessoa()
        {
            Endereco = new EnderecoModel();
            Contato = new ContatoModel();
        }

        public static bool ValorNuloOuVazio(string texto) =>
            string.IsNullOrEmpty(texto);

        public static bool DataMaiorQueHoje(DateTime data) =>
            (data > DateTime.Now || data == DateTime.Now);
    }
}


    
