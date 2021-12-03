using AugustusFahsion.Model.ValueObjects;
using System;

namespace AugustusFahsion.Model.Venda
{
    public class VendaListagemModel
    {
        public int IdVenda { get; set; }
        public string NomeCliente { get; set; }
        public string NomeColaborador{ get; set; }
        public string FormaPagamento { get; set; }
        public DinheiroModel TotalBruto { get; set; }
        public DinheiroModel TotalDesconto { get; set; }
        public DinheiroModel TotalLiquido { get; set; }
        public string Condicao { get; set; }
        public bool Pago { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
