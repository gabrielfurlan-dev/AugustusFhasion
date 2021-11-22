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
        
        public List<VendaListagemModel> ListarVendas()
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

        public List<VendaListagemModel> ListarVendaSelecionada(int idVenda)
        {
            try
            {
                var lista = VendaDAO.ListarVendaSelecionada(idVenda);
                return lista;
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
            return new List<VendaListagemModel>();
        }
        public List<VendaProdutoModel> ListarProdutosDaVenda(int idVenda) 
        {
            try
            {
                return VendaDAO.ListarProdutosDaVenda(idVenda);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return new List<VendaProdutoModel>();
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
