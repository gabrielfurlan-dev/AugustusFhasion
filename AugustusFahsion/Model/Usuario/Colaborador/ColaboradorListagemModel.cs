using AugustusFahsion.Model.Contato;
using AugustusFahsion.Model.Enderecos;
using AugustusFahsion.Model.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustusFahsion.Model
{
    public class ColaboradorListagemModel
    {
        public int IdColaborador { get; set; }
        public NomeCompletoModel NomeCompleto { get; set; }
        public EnderecoModel Endereco { get; set; }
        public ContatoModel Contato { get; set; }

        //public decimal Salario { get; set; }
        //public int Comissao { get; set; }

        public ColaboradorListagemModel()
        {
            Endereco = new EnderecoModel();
            Contato = new ContatoModel();
            NomeCompleto = new NomeCompletoModel();
        }
    }
}

