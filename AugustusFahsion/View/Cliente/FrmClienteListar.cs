using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.View

{
    public partial class FrmClienteListar : Form
    {
        private ClienteListarController _controller;
        private ClienteListagemModel _clienteModelSelecionado = new ClienteListagemModel();

        public FrmClienteListar(ClienteListarController clienteListarController)
        {
            InitializeComponent();
            _controller = clienteListarController;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (Validacoes.EhNumerico(txtProcurar.Text))
            {
                dgvLista.DataSource = _controller.ListarClientesPorId(int.Parse(txtProcurar.Text));
                return;
            }
            if (txtProcurar.Text == "%")
            {
                dgvLista.DataSource = _controller.ListarClientes();
                return;
            }
            
            dgvLista.DataSource = _controller.ListarClientesPorNome(txtProcurar.Text);
        }
        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLista.Rows.Count <= 0) return;
            SelecionarClienteModel();
            btnAlterar.Enabled = true;
        }
        private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLista.Rows.Count <= 0) return;
            var id = SelecionarClienteModel();
            var cliente = ClienteAlterarController.Buscar(id);
            AbrirFormAlterar(cliente);
        }
        private int SelecionarClienteModel() => Convert.ToInt32(dgvLista.SelectedRows[0].Cells[0].Value);
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var id = SelecionarClienteModel();
            var cliente = ClienteAlterarController.Buscar(id);
            AbrirFormAlterar(cliente);
        }
        private void AbrirFormAlterar(ClienteModel cliente)
        {
            new ClienteAlterarController().AbrirFormulario(cliente);
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e) => this.Close();
    }
}