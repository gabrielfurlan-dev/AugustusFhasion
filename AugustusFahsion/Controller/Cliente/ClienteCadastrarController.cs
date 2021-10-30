using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using AugustusFahsion.View;
using System;
using System.Windows.Forms;


namespace AugustusFahsion.Controller
{
    public class ClienteCadastrarController
    {
        public void AbrirFormulario() =>
            new ClienteCadastrar(this).Show();

        public void CadastrarCliente(ClienteModel clienteModel)
        {
            try
            {
                
                ClienteDao.CadastrarCliente(clienteModel);
                MessageBox.Show("Cliente cadastrado.");
                
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
        }
    }
}


