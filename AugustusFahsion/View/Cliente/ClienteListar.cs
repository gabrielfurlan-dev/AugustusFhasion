using System;
using System.Data;
using System.Windows.Forms;
using AugustusFahsion.Controller;
using AugustusFahsion.Model;

namespace AugustusFahsion.View

{
    public partial class ClienteListar : Form
    {
        private ClienteListarController _controller;
        private ClienteListarController clienteListarController;

        public ClienteListar(ClienteListarController clienteListarController)
        {
            InitializeComponent();
            _controller = clienteListarController;
            this.clienteListarController = clienteListarController;
        }

        private void ClienteListar_Load(object sender, EventArgs e)
        {
            dgvLista.DataSource = _controller.ListarClientes();
            dgvLista.Columns["ValorLimiteAPrazo"].DisplayIndex=16;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
