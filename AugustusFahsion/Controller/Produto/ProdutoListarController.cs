using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using AugustusFahsion.View;
using AugustusFahsion.View.Listar;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AugustusFahsion.Controller
{
    public class ProdutoListarController
    {
        public void AbrirLista() =>
            new FrmProdutoListar(this).Show();


        public List<ProdutoModel> ListarProdutos()
        {
            try
            {
                var lista = ProdutoDAO.ListarProdutos();
                return lista;
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
            return new List<ProdutoModel>();
        }
        public List<ProdutoModel> ListarProdutosPorNome(string nome)
        {
            try
            {
                var lista = ProdutoDAO.ListarProdutosPorNome(nome);
                return lista;
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
            return new List<ProdutoModel>();
        }
        public List<ProdutoModel> ListarProdutosPorId(int id)
        {
            try
            {
                var lista = ProdutoDAO.ListarProdutosPorId(id);
                return lista;
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
            return new List<ProdutoModel>();
        }

        //listar produtos ativos
        public List<ProdutoModel> ListarProdutosAtivos()
        {
            try
            {
                var lista = ProdutoDAO.ListarProdutosAtivos();
                return lista;
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
            return new List<ProdutoModel>();
        }
        public List<ProdutoModel> ListarProdutosAtivosPorNome(string nome)
        {
            try
            {
                var lista = ProdutoDAO.ListarProdutosAtivosPorNome(nome);
                return lista;
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
            return new List<ProdutoModel>();
        }
        public List<ProdutoModel> ListarProdutosAtivosPorId(int id)
        {
            try
            {
                var lista = ProdutoDAO.ListarProdutosAtivosPorId(id);
                return lista;
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
            return new List<ProdutoModel>();
        }
    }
}
