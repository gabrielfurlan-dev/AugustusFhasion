using AugustusFahsion.Model.ValueObjects;

namespace AugustusFahsion.Model.Relatorio
{
    class RelatorioClientes
    {
        public string Nome { get; set; }
        public int QuantidadeVendas { get; set; }
        public DinheiroModel TotalBruto { get; set; }
        public DinheiroModel Desconto { get => TotalLiquido.RetornarValor - TotalBruto.RetornarValor; }
        public DinheiroModel TotalLiquido { get; set; }
    }
}
