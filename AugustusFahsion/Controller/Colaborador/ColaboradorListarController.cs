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


        public List<ColaboradorListagem> ListarColaborador()
        {
            try
            {
                var lista = ColaboradorDAO.ListarColaboradores();
                return lista;
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }

            return new List<ColaboradorListagem>();
        }
    }
}
