using AugustusFahsion.Model.ValueObjects;

namespace AugustusFahsion.Model.Relatorio
{
    public class RelatorioClientes
    {
        public string Nome { get; set; }
        public int QuantidadeVenda { get; set; }
        public DinheiroModel TotalBruto { get; set; }
        public DinheiroModel Desconto { get => TotalBruto.RetornarValor - TotalLiquido.RetornarValor; }
        public DinheiroModel TotalLiquido { get; set; }
    }
}
