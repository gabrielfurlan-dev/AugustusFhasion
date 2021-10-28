using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.View
{
    public partial class ColaboradorListar : Form
    {
        private ColaboradorListarController _controller;
        //private ColaboradorListarController colaboradorListarController;
        private ColaboradorModel _colaboradorModelSelecionado;
        public ColaboradorListar(ColaboradorListarController colaboradorListarController)
        {
            InitializeComponent();
            _controller = colaboradorListarController;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ColaboradorListar_Load(object sender, EventArgs e)
        {
            dgvLista.DataSource = _controller.ListarColaborador();
            dgvLista.Columns["Salario"].DisplayIndex = 16;
            dgvLista.Columns["Comissao"].DisplayIndex = 17;
            dgvLista.Columns["Banco"].DisplayIndex = 18;
            dgvLista.Columns["Agencia"].DisplayIndex = 19;
            dgvLista.Columns["Conta"].DisplayIndex = 20;
            dgvLista.Columns["TipoConta"].DisplayIndex = 21;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvLista_MouseClick(object sender, MouseEventArgs e)
        {
            SelecionarColaboradorModel();
        }

        private void dgvLista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SelecionarColaboradorModel();
            AbrirFormAlterar();
        }

        private void SelecionarColaboradorModel()
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
                _colaboradorModelSelecionado = dgvLista.Rows[indiceselecionado].DataBoundItem as ColaboradorModel;
            }
        }
        private void AbrirFormAlterar()
        {
            if (_colaboradorModelSelecionado == null) return;

            new ColaboradorAlterarController().AbrirFormulario(_colaboradorModelSelecionado);
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            new ColaboradorAlterarController().AbrirFormulario();
        }
    }
}
