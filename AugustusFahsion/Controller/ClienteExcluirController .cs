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
    public class ClienteExcluirController
    {
        public void AbrirFormulario() =>
            new ClienteExcluir(this).Show();

        public static void ExcluirCliente(int id)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    ClienteDao.ExcluirCliente(conexao, id);
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }

        }
    }
}


