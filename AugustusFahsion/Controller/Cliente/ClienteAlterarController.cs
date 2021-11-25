using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using AugustusFahsion.View;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.Controller
{
    public class ClienteAlterarController
    {
        public void AbrirFormulario() =>
            new FrmClienteAlterar(this).Show();

        public void AbrirFormulario(ClienteModel clienteModelSelecionado)
        {
            new FrmClienteAlterar(this, clienteModelSelecionado).Show();
        }

        public static ClienteModel Buscar(int id)
        {
                return ClienteDAO.BuscarCliente(id);
        }

        public void AtualizarCliente(ClienteModel clienteModel)
        {
            try
            {
                if (ClienteDAO.ValidaId(clienteModel.IdPessoa))
                {
                    ClienteDAO.AlterarCliente(clienteModel);
                    MessageBox.Show("Cliente alterado!");
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
        }

        //================================
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
    }
}
