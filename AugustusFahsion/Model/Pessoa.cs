using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustusFahsion.Model
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string NumeroEndereco { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
    }
}
