using AugustusFahsion.Model.ValueObjects;
using AugustusFahsion.Model.Venda;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AugustusFahsion.Model
{
    public class VendaModel
    {
        public int IdVenda { get; set; }
        public int IdColaborador { get; set; }
        public ClienteModel Cliente { get; set; }
        public string FormaPagamento { get; set; }
        public DinheiroModel TotalBruto {get => ListaDeItens.Sum(x => (x.PrecoVenda.RetornarValor) * (x.Quantidade));}
        public DinheiroModel TotalLiquido {get => ListaDeItens.Sum(x => x.TotalLiquido.RetornarValor);}
        public DinheiroModel TotalDesconto {get => ListaDeItens.Sum(x => (x.Desconto));}
        public decimal TotalLucro {get => ListaDeItens.Sum(x => x.Lucro);}
        public int Pago { get; set; }
        public DateTime DataVenda    { get; set; }

        public List<VendaProdutoModel> ListaDeItens { get; set; }
        public VendaModel()
        {
            ListaDeItens = new List<VendaProdutoModel>();
            Cliente = new ClienteModel();
        }
    }
}
