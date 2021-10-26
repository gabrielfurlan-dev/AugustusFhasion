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
            new ProdutoListar(this).Show();


        public List<ProdutoModel> ListarProdutos()
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
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
