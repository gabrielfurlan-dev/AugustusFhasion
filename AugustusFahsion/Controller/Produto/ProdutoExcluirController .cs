using System;
using System.Windows.Forms;
using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using AugustusFahsion.View.Excluir;

namespace AugustusFahsion.Controller
{
    public class ProdutoExcluirController
    {
        public void AbrirFormulario() =>
            new ProdutoExcluir(this).Show();

        public bool ValidarId(int id)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    return ProdutoDAO.ValidaId(conexao, id);
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
                return false;
            }
        }
        public void ExcluirProduto(ProdutoModel produto)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    ProdutoDAO.ExcluirProduto(conexao, produto);
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }

        }
    }
}


