using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using AugustusFahsion.Model.Venda;
using AugustusFahsion.View.Venda;

namespace AugustusFahsion.Controller.Venda
{
    public class VendaAlterarController
    {
        public void AbrirFormulario(VendaModel venda) => new FrmVendaAlterar(this, venda).Show();
        public VendaModel BuscarVenda(int id) => 
            VendaDAO.BuscarVenda(id);

        public VendaProdutoModel BuscarDadosDoProdutoDaVenda(int idProduto) =>
                VendaDAO.BuscarDadosDoProdutoDaVenda(idProduto);
    }
}
