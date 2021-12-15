using AugustusFahsion.Model.ValueObjects;
using System;

namespace AugustusFahsion.Model
{
    public class ProdutoModel
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string Fabricante { get; set; }
        public DinheiroModel PrecoCusto { get; set; }
        public DinheiroModel PrecoVenda { get; set; }
        public string CodigoBarras { get; set; }
        public int QuantidadeEstoque { get; set; }
        public string Condicao { get; set; }

        public static decimal ValorTotalBrutoProduto(decimal precoVenda, int quantidade) =>
            precoVenda * quantidade;

        public static decimal DescontoPorcentagemEmDecimal(decimal valorTotalBruto, int desconto)
        {
            return valorTotalBruto * (desconto * Convert.ToDecimal(0.01));
        }


        public static decimal ValorTotalDescontoProduto(int desconto, int quantidade, decimal precoProduto)
        {
            var valorTotalBrutoProduto = ValorTotalBrutoProduto(precoProduto, quantidade);
            var valorTotalDesconto = ValorTotalDesconto(precoProduto, quantidade, desconto);

            return valorTotalBrutoProduto - valorTotalDesconto;
        }

        public static decimal ValorProdutoLucro(decimal ProdutoLucroUnitario, int Quantidade, int Desconto, decimal PrecoProduto)
        {
            var valorTotalDescontoProduto = ValorTotalDescontoProduto(Desconto, Quantidade, PrecoProduto);

            return (ProdutoLucroUnitario * Quantidade) - valorTotalDescontoProduto;
        }
        public static decimal ValorTotalDesconto(decimal precoVenda, int quantidade, int desconto)
        {
            var valorTotalBrutoProduto = ValorTotalBrutoProduto(precoVenda, quantidade);
            var descontoEmPorcentagem = DescontoPorcentagemEmDecimal(valorTotalBrutoProduto, desconto);

            return valorTotalBrutoProduto - descontoEmPorcentagem;
        }

    }

}
