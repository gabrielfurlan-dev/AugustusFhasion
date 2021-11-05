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
        private ClienteListagemModel _clienteModelSelecionado = new ClienteListagemModel();

        public ClienteListar(ClienteListarController clienteListarController)
        {
            InitializeComponent();
            _controller = clienteListarController;
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
<<<<<<< HEAD
=======

        private void ClienteListar_Load(object sender, EventArgs e)
        {
            dgvLista.DataSource = _controller.ListarClientes();
        }

>>>>>>> parent of 0fbe93f (Adicionado funcionalidade de busca personalizada)
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var id = SelecionarClienteModel();

            var cliente = ClienteAlterarController.Buscar(id);

            AbrirFormAlterar(cliente);
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

<<<<<<< HEAD

=======
>>>>>>> parent of 0fbe93f (Adicionado funcionalidade de busca personalizada)
        private void AbrirFormAlterar(ClienteModel cliente)
        {
            //if (_clienteModelSelecionado == null) return;

            new ClienteAlterarController().AbrirFormulario(cliente);
            this.Close();
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarClienteModel();
<<<<<<< HEAD
            btnAlterar.Enabled = true;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (Validar.EhNumerico(txtProcurar.Text))
            {
                dgvLista.DataSource = _controller.ListarClientesPorId(int.Parse(txtProcurar.Text));
            }
            else if (txtProcurar.Text == "%")
            {
                dgvLista.DataSource = _controller.ListarClientes();
            }
            else
            {
                dgvLista.DataSource = _controller.ListarClientesPorNome(txtProcurar.Text);
            }
=======
>>>>>>> parent of 0fbe93f (Adicionado funcionalidade de busca personalizada)
        }

    }
}
