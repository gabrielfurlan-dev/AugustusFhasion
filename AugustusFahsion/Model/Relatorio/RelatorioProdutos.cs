using AugustusFahsion.Model.ValueObjects;
using System;

namespace AugustusFahsion.Model.Relatorio
{
    public class RelatorioProdutos
    {
        public string Nome{ get; set; }
        public int QuantidadeVendida { get; set; }
        public DinheiroModel TotalBruto { get; set; }
        public DinheiroModel TotalDesconto { get; set; }
        public DinheiroModel TotalPrecoLiquido { get; set; }
        public DinheiroModel TotalCusto { get; set; }
        public DinheiroModel TotalLucroReais { get; set; }
        public string TotalLucroPorcentagem 
        {
            get => (TotalLucroReais.RetornarValor * 100 / TotalCusto.RetornarValor).ToString("F") + "%";
        }
    }
}
