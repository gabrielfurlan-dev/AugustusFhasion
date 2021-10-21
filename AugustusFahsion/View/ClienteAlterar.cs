using AugustusFahsion.Controller;
using System;
using System.Windows.Forms;
using AugustusFahsion.Model;

namespace AugustusFahsion.View
{
    public partial class ClienteAlterar : Form
    {
        private ClienteAlterarController _controller;
        private ClienteModel clienteModel;

        public ClienteAlterar(ClienteAlterarController clienteAlterarController)
        {
            InitializeComponent();

            _controller = clienteAlterarController;


            clienteModel = new ClienteModel
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
            };
        }

        
        public void btnConsultarId_Click(object sender, EventArgs e)
        {
            //var idSolicitado = txtId.Text;
            var validaID = new ClienteAlterarController().ValidarId(int.Parse(txtId.Text));

            if (validaID)
            {
                clienteModel.Id = int.Parse(txtId.Text);
                MessageBox.Show("id válido!");
            }
            else {
                MessageBox.Show("id invalido!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            clienteModel.Nome = txtNome.Text;
            clienteModel.Email = txtEmail.Text;
            clienteModel.Telefone = txtTelefone.Text;

            _controller.AtualizarCliente(clienteModel);
            this.Close();
        }
    }
}
