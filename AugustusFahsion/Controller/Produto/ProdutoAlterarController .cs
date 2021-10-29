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
            new ProdutoAlterar(this).Show();


        public bool ValidarId(int id)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    return ProdutoDAO.ValidaId(conexao, id);
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
                return false;
            }
        }

        public ProdutoModel Buscar(int id)
        {
            using (var conexao = new SqlConexao().Connection())
            {
                return ProdutoDAO.Buscar(conexao, id);
            }
        }

        public void AtualizarProduto(ProdutoModel produtoModel)
        {

            try
            {
                using (var conexao = new SqlConexao().Connection())

                if (ProdutoDAO.ValidaId(conexao, produtoModel.Id))
                {
                    {
                        ProdutoDAO.AlterarProduto(conexao, produtoModel);
                        MessageBox.Show("Produto alterado!");
                    }
                }
            }


            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
        }


    }
}


