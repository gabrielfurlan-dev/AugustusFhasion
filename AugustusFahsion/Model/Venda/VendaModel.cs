﻿using AugustusFahsion.Model.Venda;
using System.Collections.Generic;
using System.Linq;

namespace AugustusFahsion.Model
{
    public class VendaModel
    {
        public int IdVenda { get; set; }
        public int IdColaborador { get; set; }
        public int IdCliente { get; set; }
        public string FormaPagamento { get; set; }
        public decimal TotalBruto 
        {
            get => ListaDeItens.Sum(x => (x.PrecoVenda) * (x.Quantidade));
        }
        public decimal TotalLiquido 
        {
            get => ListaDeItens.Sum(x => x.PrecoLiquido);
        }
        public decimal TotalDesconto {get => ListaDeItens.Sum(x => (x.Desconto));}

        public decimal TotalLucro
        {
            get => ListaDeItens.Sum(x => (x.Lucro));
        }

        public List<VendaProdutoModel> ListaDeItens { get; set; }
        public VendaModel() => ListaDeItens = new List<VendaProdutoModel>();
        
    }
}
