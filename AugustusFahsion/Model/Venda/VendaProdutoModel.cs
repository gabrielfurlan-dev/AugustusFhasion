using AugustusFahsion.Model.ValueObjects;
using System;

namespace AugustusFahsion.Model.Venda
{
    public class VendaProdutoModel
    {
        public int IdProduto { get; set; }
        public string Nome{ get; set; }
        public int IdVenda { get; set; }
        public DinheiroModel PrecoVenda { get; set; }
        public int Quantidade { get; set; }
        public DinheiroModel TotalLiquido { get; set; }
        public int Desconto { get; set; }
        public DinheiroModel TotalBruto { get; set; }
        public decimal Lucro { get; set; }
        public Guid IdProdutoGuid{ get; set; }

        //public decimal ValorTotalBrutoProduto(VendaProdutoModel produto) => produto.PrecoCusto.RetornarValor * produto.Quantidade;
    }
}
