using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using AugustusFahsion.View;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.Controller
{
    public class ClienteAlterarController
    {
        public void AbrirFormulario() 
        {
            var form = new FrmClienteAlterar(this);
            form.MdiParent = MDISingleton.InstaciaMDI();
            form.Show();
        }
        public void AbrirFormulario(ClienteModel clienteModelSelecionado)
        {
            var form = new FrmClienteAlterar(this, clienteModelSelecionado);
            form.MdiParent = MDISingleton.InstaciaMDI();
            form.Show();
        }

        public static ClienteModel Buscar(int id)
        {
                var cliente =  ClienteDAO.BuscarCliente(id);
            cliente.ValorLimiteGasto = ClienteDAO.ValorLimiteGasto(id);
            return cliente;
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
