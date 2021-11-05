﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustusFahsion.Model.Enderecos
{
    public class EnderecoModel
    {
        public int IdEndereco { get; set; }
        public int IdPessoa { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string NumeroEndereco { get; set; }

        public override string ToString()
        {
            return $"CEP:{Cep} | {Logradouro}, nº: {NumeroEndereco}, {Bairro}, {Complemento}. {Cidade} - {Uf}";
        }
    }
}
