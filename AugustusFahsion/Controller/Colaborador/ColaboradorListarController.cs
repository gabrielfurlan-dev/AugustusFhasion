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


        public List<ColaboradorListagemModel> ListarColaborador()
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

            return new List<ColaboradorListagemModel>();
        }

        public List<ColaboradorListagemModel> ListarColaboradorPorNome(string nome)
        {
            try
            {
                var lista = ColaboradorDAO.BuscarColaboradoresPorNome(nome);
                return lista;
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }

            return new List<ColaboradorListagemModel>();
        }
        public List<ColaboradorListagemModel> ListarColaboradorPorId(int id)
        {
            try
            {
                var lista = ColaboradorDAO.BuscarColaboradoresPorId(id);
                return lista;
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }

            return new List<ColaboradorListagemModel>();
        }
    }
}
