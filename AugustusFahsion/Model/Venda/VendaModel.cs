using AugustusFahsion.Model.Venda;
using System.Collections.Generic;
using System.Linq;

namespace AugustusFahsion.Model
{
    public class VendaModel
    {
        public int IdVenda { get; set; }
        public int IdColaborador { get; set; }
        public int IdCliente { get; set; }
        public string FormaPagamento { get; set; }
        public decimal TotalBruto 
        {
            get => VendaProdutoModel.Sum(x => (x.PrecoVenda) * (x.Quantidade)); set { }
        }
        public decimal TotalLiquido 
        {
            get => VendaProdutoModel.Sum(x =>  ((x.PrecoLiquido) * (x.Quantidade)) - (x.Desconto)); set { }
        }
        public decimal TotalDesconto 
        { 
            get => VendaProdutoModel.Sum(x => (x.Desconto)); set { }
        }
        public List<VendaProdutoModel> VendaProdutoModel { get; set; }
        public VendaModel() => VendaProdutoModel = new List<VendaProdutoModel>();
        
    }
}
