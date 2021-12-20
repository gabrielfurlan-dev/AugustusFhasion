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
        public DinheiroModel TotalBruto { get => ListaDeItens.Sum(x => (x.PrecoVenda.RetornarValor) * (x.Quantidade)); }
        public DinheiroModel TotalLiquido { get => ListaDeItens.Sum(x => x.TotalLiquido.RetornarValor); }
        public DinheiroModel TotalDesconto { get => TotalBruto.RetornarValor - TotalLiquido.RetornarValor; }
        public decimal TotalLucro { get => ListaDeItens.Sum(x => x.Lucro); }
        public bool Pago { get; set; }
        public DateTime DataVenda { get; set; }
        public string Condicao { get; set; }

        public List<VendaProdutoModel> ListaDeItens { get; set; }
        public VendaModel()
        {
            ListaDeItens = new List<VendaProdutoModel>();
            Cliente = new ClienteModel();
        }

        public bool VerificarLimiteGastoCompraAPrazoFoiAtingido( decimal totalLiquidoOriginal)
        {
            var valorGasto = Cliente.ValorLimiteGasto.RetornarValor - totalLiquidoOriginal;

            if (valorGasto + TotalLiquido.RetornarValor > Cliente.ValorLimiteAPrazo.RetornarValor)
            {              
                return false;
            }
            return true;
        }
    }
}
