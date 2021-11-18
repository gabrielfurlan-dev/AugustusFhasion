using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustusFahsion.Model.Venda
{
    class CarrinhoModel
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public int Desconto { get; set; }
        public decimal PrecoLiquido { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal total { get; set; }

        public Guid IdProdutoGuid { get; set; }
    }
}