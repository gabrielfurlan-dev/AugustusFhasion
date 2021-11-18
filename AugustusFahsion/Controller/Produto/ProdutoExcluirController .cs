using System;
using System.Windows.Forms;
using AugustusFahsion.DAO;
using AugustusFahsion.Model;

namespace AugustusFahsion.Controller
{
    public class ProdutoExcluirController
    {
        public void ExcluirProduto(ProdutoModel produto)
        {
            try
            {
               ProdutoDAO.ExcluirProduto(produto);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
        }

        //==============================
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
    }
}


