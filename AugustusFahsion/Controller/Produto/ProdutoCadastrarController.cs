using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using AugustusFahsion.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AugustusFahsion.Controller
{
    public class ProdutoCadastrarController
    {
        public void AbrirFormulario() =>
            new FrmProdutoCadastrar(this).Show();

        public void CadastrarProduto(ProdutoModel produtoModel)
        {
            try
            {
                ProdutoDAO.CadastrarProduto(produtoModel);
                MessageBox.Show("Produto cadastrado.");
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
        }

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
    }
}


