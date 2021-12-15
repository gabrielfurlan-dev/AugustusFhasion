using AugustusFahsion.Controller;
using AugustusFahsion.Controller.Venda;
using AugustusFahsion.Model.ValueObjects;
using AugustusFahsion.Model.Venda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AugustusFahsion.Model
{
    public class VendaModel
    {
        public int IdVenda { get; set; }
        public int IdColaborador { get; set; }
        public ClienteModel Cliente { get; set; }
        public string FormaPagamento { get; set; }
        public DinheiroModel TotalBruto { get => ListaDeItens.Sum(x => (x.PrecoVenda.RetornarValor) * (x.Quantidade)); }
        public DinheiroModel TotalLiquido { get => ListaDeItens.Sum(x => x.TotalLiquido.RetornarValor); }
        public DinheiroModel TotalDesconto { get => TotalBruto.RetornarValor - TotalLiquido.RetornarValor; }
        public decimal TotalLucro { get => ListaDeItens.Sum(x => x.Lucro); }
        public bool Pago { get; set; }
        public DateTime DataVenda { get; set; }
        public string Condicao { get; set; }

        public List<VendaProdutoModel> ListaDeItens { get; set; }
        public VendaModel()
        {
            ListaDeItens = new List<VendaProdutoModel>();
            Cliente = new ClienteModel();
        }

        public static bool VerificarLimiteGastoCompraAPrazoFoiAtingido
            (
            int idCliente,
            DinheiroModel TotalLiquido,
            decimal totalLiquidoOriginal
            )
        {
            //Subtrair o totalLiquido original da venda para comparar valor limite a prazo
            var valorGasto = VendaRegistrarController.ValorLimiteGasto(idCliente).RetornarValor - totalLiquidoOriginal;

            var cliente = ClienteAlterarController.Buscar(idCliente);
            var valorLimite = cliente.ValorLimiteAPrazo;
            var valorCompra = TotalLiquido;

            if (valorGasto + valorCompra.RetornarValor > valorLimite.RetornarValor)
            {
                MessageBox.Show($"Valor Limite de compra a prazo máximo atingido: {valorLimite.ValorFormatado}" +
                                $"\nValor total gasto em compras a prazo {valorGasto.ToString("c")}" +
                                $"\nValor da compra: {valorCompra.ValorFormatado}");
                return false;
            }
            return true;
        }
    }
}
