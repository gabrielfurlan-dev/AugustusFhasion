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
        private ClienteListarController clienteListarController;
        private ClienteModel _clienteModelSelecionado;


        public ClienteListar(ClienteListarController clienteListarController)
        {
            InitializeComponent();
            _controller = clienteListarController;
            this.clienteListarController = clienteListarController;
        }

        private void ClienteListar_Load(object sender, EventArgs e)
        {
            dgvLista.DataSource = _controller.ListarClientes();
            dgvLista.Columns["ValorLimiteAPrazo"].DisplayIndex = 16;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLista_MouseClick(object sender, MouseEventArgs e)
        {
            SelecionarClienteModel();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AbrirFormAlterar();
        }

        private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarClienteModel();
            AbrirFormAlterar();
        }

        private void SelecionarClienteModel()
        {
            int indiceselecionado = -1;
            // Se o usuário selecionou a Linha
            if (dgvLista.SelectedRows.Count > 0)
            {
                indiceselecionado = dgvLista.SelectedRows[0].Index;
            }
            else
            { // Se o usuário selecionou a célula
                if (dgvLista.SelectedCells.Count > 0)
                {
                    indiceselecionado = dgvLista.SelectedCells[0].RowIndex;
                }
            }

            if (indiceselecionado != -1)
            {
                _clienteModelSelecionado = dgvLista.Rows[indiceselecionado].DataBoundItem as ClienteModel;
            }
        }

        private void AbrirFormAlterar()
        {
            if (_clienteModelSelecionado == null) return;

            new ClienteAlterarController().AbrirFormulario(_clienteModelSelecionado);
            this.Close();
        }
    }
}
