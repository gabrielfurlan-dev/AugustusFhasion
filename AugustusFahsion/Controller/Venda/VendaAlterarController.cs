using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using AugustusFahsion.Model.Venda;
using AugustusFahsion.View.Venda;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.Controller.Venda
{
    public class VendaAlterarController
    {
        public void AbrirFormulario(VendaModel venda) => new FrmVendaAlterar(this, venda).Show();
        public VendaModel BuscarVenda(int id) => 
            VendaDAO.BuscarVenda(id);

        public VendaProdutoModel BuscarDadosDoProdutoDaVenda(int idProduto) =>
                VendaDAO.BuscarDadosDoProdutoDaVenda(idProduto);

        public static void InativarVenda(VendaModel vendaModel)
        {
            try
            {
                VendaDAO.InativarVenda(vendaModel);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
        }
        public static void AlterarVenda(VendaModel vendaModel)
        {
            try
            {
                VendaDAO.AlterarVenda(vendaModel);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
        }

        internal int BuscarQuantidadeOriginalDaVenda(int idProduto, int IdVenda)
        {
            return VendaDAO.BuscarQuantidadeOriginalDaVenda(idProduto, IdVenda);
        }

        internal int BuscarEstoqueOriginal(int idProduto)
        {
            return ProdutoDAO.BuscarEstoqueOriginal(idProduto);
        }
    }
}
