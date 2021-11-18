using AugustusFahsion.DAO;
using AugustusFahsion.Model.Venda;
using AugustusFahsion.View.Venda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AugustusFahsion.Controller.Venda
{
    public class VendaListarController
    {

        public void AbrirLista() =>
            new FrmVendaListar(this).Show();
        
        public List<VendaListagemModel> ListarProdutos()
        {
            try
            {
                var lista = VendaDAO.ListarVendas();
                return lista;
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
            return new List<VendaListagemModel>();
        }
        //public List<ProdutoModel> ListarProdutosPorNome(string nome)
        //{
        //    try
        //    {
        //        var lista = ProdutoDAO.ListarProdutosPorNome(nome);
        //        return lista;
        //    }
        //    catch (Exception excecao)
        //    {
        //        MessageBox.Show(excecao.Message);
        //    }
        //    return new List<ProdutoModel>();
        //}
        //public List<ProdutoModel> ListarProdutosPorId(int id)
        //{
        //    try
        //    {
        //        var lista = ProdutoDAO.ListarProdutosPorId(id);
        //        return lista;
        //    }
        //    catch (Exception excecao)
        //    {
        //        MessageBox.Show(excecao.Message);
        //    }
        //    return new List<ProdutoModel>();
        //}
    }
}
