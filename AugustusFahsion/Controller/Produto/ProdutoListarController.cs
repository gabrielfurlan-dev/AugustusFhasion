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
    }
}
