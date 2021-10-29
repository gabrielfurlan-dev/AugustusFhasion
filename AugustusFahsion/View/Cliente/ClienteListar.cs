using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace AugustusFahsion.View

{
    public partial class ClienteListar : Form
    {
        private ClienteListarController _controller;
        private ClienteListagem _clienteModelSelecionado = new ClienteListagem();


        public ClienteListar(ClienteListarController clienteListarController)
        {
            InitializeComponent();
            _controller = clienteListarController;
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClienteListar_Load(object sender, EventArgs e)
        {
            dgvLista.DataSource = _controller.ListarClientes();
        }


        private void dgvLista_MouseClick(object sender, MouseEventArgs e)
        {
            SelecionarClienteModel();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            new ClienteAlterarController().AbrirFormulario();
        }

        private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = SelecionarClienteModel();
            
            var cliente = ClienteAlterarController.Buscar(id);
            
            AbrirFormAlterar(cliente);
            
        }

        private int SelecionarClienteModel()
        {
            int id = Convert.ToInt32(dgvLista.SelectedRows[0].Cells[0].Value);

            return id;
        }

        private void AbrirFormAlterar(ClienteModel cliente)
        {
            //if (_clienteModelSelecionado == null) return;

            new ClienteAlterarController().AbrirFormulario(cliente);
            this.Close();
        }
    }
}
