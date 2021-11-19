using System;

namespace AugustusFahsion.Model.Venda
{
    public class VendaProdutoModel
    {
        public int IdProduto { get; set; }
        public string Nome{ get; set; }
        public int IdVenda { get; set; }
        public decimal PrecoVenda { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoLiquido { get; set; }
        public int Desconto { get; set; }
        public decimal Total { get; set; }
        public decimal Lucro{ get; set; }
        public Guid IdProdutoGuid{ get; set; }
    }
}
