using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AugustusFahsion.Controller;
using AugustusFahsion.View;
using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using System.Windows.Forms;

namespace AugustusFahsion.Controller
{
    public class ProdutoCadastrarController
    {
        public void AbrirFormulario() =>
            new ProdutoCadastrar(this).Show();

        public void CadastrarProduto(ProdutoModel produtoModel)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    ProdutoDAO.CadastrarProduto(conexao, produtoModel);
                    MessageBox.Show("Produto cadastrado.");
                }
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
                using (var conexao = new SqlConexao().Connection())
                {
                    var lista = ProdutoDAO.ListarProdutos(conexao);
                    return lista;
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }

            return new List<ProdutoModel>();
        }
    }
}


