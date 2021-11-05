using System;
using System.Windows.Forms;
using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using AugustusFahsion.View;

namespace AugustusFahsion.Controller
{
    public class ClienteExcluirController
    {
        public void AbrirFormulario() =>
            new ClienteExcluir(this).Show();

        public bool ValidarId(int id)
        {
            try
            {
                return ClienteDAO.ValidaId(id);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
                return false;
            }
        }
        public void ExcluirCliente(ClienteModel cliente)
        {
            try
            {
               ClienteDAO.ExcluirCliente(cliente);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }

        }
    }
}


