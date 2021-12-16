using AugustusFahsion.Model.Contato;
using AugustusFahsion.Model.Enderecos;
using AugustusFahsion.Model.ValueObjects;
using System;
using System.Linq;

namespace AugustusFahsion.Model
{
    public abstract class Pessoa
    {
        public int Id { get; set; } 
        public NomeCompletoModel NomeCompleto { get; set; }
        public string Sexo { get; set; }
        public CpfModel Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public EnderecoModel Endereco { get; set; }
        public ContatoModel Contato { get; set; }
        public Pessoa()
        {
            Endereco = new EnderecoModel();
            Contato = new ContatoModel();
            NomeCompleto = new NomeCompletoModel();
        }
        public Pessoa(NomeCompletoModel nomeCompleto)
        {
            //construtor vazio
        }

        public static bool ValorNuloOuVazio(string texto) =>
            string.IsNullOrEmpty(texto);

        public static bool DataMaiorQueHoje(DateTime data) =>
            (data > DateTime.Now || data == DateTime.Now);
    }
}


    
