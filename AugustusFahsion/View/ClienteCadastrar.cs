using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AugustusFahsion.Controller;
using AugustusFahsion.Model;

namespace AugustusFahsion.View
{
    public partial class ClienteCadastrar : Form
    {
        private ClienteCadastrarController _controller;
        private ClienteModel clienteModel;

        public ClienteCadastrar(ClienteCadastrarController clienteCadastrarController)
        {
            InitializeComponent();
            _controller = clienteCadastrarController;


            clienteModel = new ClienteModel
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
            };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            clienteModel.Nome = txtNome.Text;
            clienteModel.Email = txtEmail.Text;
            clienteModel.Telefone = txtTelefone.Text;

            _controller.CadastrarCliente(clienteModel);
            this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClienteCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
