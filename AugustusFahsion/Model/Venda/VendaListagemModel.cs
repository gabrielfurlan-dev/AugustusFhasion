namespace AugustusFahsion.Model.Venda
{
    public class VendaListagemModel
    {
        public int IdVenda { get; set; }
        public string NomeCliente { get; set; }
        public string NomeColaborador{ get; set; }
        public string FormaPagamento { get; set; }
        public decimal TotalBruto { get; set; }
        public decimal TotalDesconto { get; set; }
        public decimal TotalLiquido { get; set; }
        public string Condicao { get; set; }
    }
}
