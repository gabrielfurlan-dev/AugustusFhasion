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
            new ClienteAlterar(this).Show();
        public void AbrirFormulario(ClienteModel clienteModelSelecionado)
        {
            ClienteExcluirController clienteExcluirController = new ClienteExcluirController();
            new ClienteAlterar(this, clienteModelSelecionado, clienteExcluirController).Show();
        }
        public bool ValidarId(int id)
        {
            try
            {
                return ClienteDao.ValidaId(id);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
                return false;
            }
        }
        public static ClienteModel Buscar(int id)
        {
                return ClienteDao.Buscar(id);
        }
        public void AtualizarCliente(ClienteModel clienteModel)
        {
            try
            {
                if (ClienteDao.ValidaId(clienteModel.IdPessoa))
                {
                    ClienteDao.AlterarCliente(clienteModel);
                    MessageBox.Show("Cliente alterado!");
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
        }
    }
}


