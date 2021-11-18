using System;

namespace AugustusFahsion.Model.Venda
{
    public class VendaProdutoModel
    {
        public Guid IdProdutoGuid{ get; set; }
        public int IdProduto { get; set; }
        public int IdVenda { get; set; }
        public decimal PrecoVenda { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoLiquido { get; set; }
        public int Desconto { get; set; }
        public decimal Total { get; set; }
    }
}
