using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using AugustusFahsion.View.Alterar;
using System;
using System.Windows.Forms;


namespace AugustusFahsion.Controller
{
    public class ProdutoAlterarController
    {

        public void AbrirFormulario() =>
            new FrmProdutoAlterar(this).Show();
        public void AbrirFormulario(ProdutoModel produtoModelSelecionado)
        {
            ProdutoExcluirController produtoExcluirController = new ProdutoExcluirController();
            new FrmProdutoAlterar(this, produtoExcluirController, produtoModelSelecionado).Show();
        }

        public bool ValidarId(int id)
        {
            try
            {
                return ProdutoDAO.ValidaId(id);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
                return false;
            }
        }

        public ProdutoModel Buscar(int id)
        {
            return ProdutoDAO.Buscar(id);    
        }

        public void AtualizarProduto(ProdutoModel produtoModel)
        {
            try
            {
                if (ProdutoDAO.ValidaId(produtoModel.IdProduto))
                {
                    ProdutoDAO.AlterarProduto(produtoModel);
                    MessageBox.Show("Produto alterado!");
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
        }
    }
}


