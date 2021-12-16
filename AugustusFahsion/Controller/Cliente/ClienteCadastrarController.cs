using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using AugustusFahsion.View;
using System;
using System.Windows.Forms;


namespace AugustusFahsion.Controller
{
    public class ClienteCadastrarController
    {
        public void AbrirFormulario()
        {
            var form = new FrmClienteCadastrar(this);
            form.MdiParent = MDISingleton.InstaciaMDI();
            form.Show();
        }

        public void CadastrarCliente(ClienteModel clienteModel)
        {
            try
            {
                ClienteDAO.CadastrarCliente(clienteModel);
                MessageBox.Show("Cliente cadastrado.");
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
        }
    }
}


