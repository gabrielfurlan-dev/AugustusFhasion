using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AugustusFahsion.View;
using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using System.Windows.Forms;

namespace AugustusFahsion.Controller
{
    public class ColaboradorListarController
    {
        public void AbrirLista() =>
            new ColaboradorListar(this).Show();


        public List<ColaboradorModel> ListarColaborador()
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    var lista = ColaboradorDAO.ListarColaboradores(conexao);
                    return lista;
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }

            return new List<ColaboradorModel>();
        }
    }
}
