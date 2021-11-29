﻿using AugustusFahsion.Model.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustusFahsion.Model
{
    public class ProdutoModel
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string Fabricante { get; set; }
        public DinheiroModel PrecoCusto { get; set; }
        public DinheiroModel PrecoVenda { get; set; }
        public string CodigoBarras { get; set; }
        public int QuantidadeEstoque { get; set; }
        public string Condicao { get; set; }
    }
}
