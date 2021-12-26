using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.View
{
    public partial class FrmColaboradorListar : Form
    {
        private readonly ColaboradorListarController _controller;
        private ColaboradorModel _colaboradorModelSelecionado = new ColaboradorModel();
        public FrmColaboradorListar(ColaboradorListarController colaboradorListarController)
        {
            InitializeComponent();
            _controller = colaboradorListarController;
        }

        private void btnFechar_Click(object sender, EventArgs e) => this.Close();

        private void btnAlterar_Click(object sender, EventArgs e) =>
            AbirFormEpreencherOsCampos();

        private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e) =>
            AbirFormEpreencherOsCampos();
        
        private void AbrirFormAlterar(ColaboradorModel colaborador)
        {
            new ColaboradorAlterarController().AbrirFormulario(colaborador);
            this.Close();
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarColaboradorModel();
            btnAlterar.Enabled = true;
        }


        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (Validacoes.EhNumerico(txtProcurar.Text))
            {
                dgvLista.DataSource = _controller.ListarColaboradorPorId(int.Parse(txtProcurar.Text));
                return;
            }
            if (txtProcurar.Text == "%")
            {
                dgvLista.DataSource = _controller.ListarColaborador();
                return;
            }

            dgvLista.DataSource = _controller.ListarColaboradorPorNome(txtProcurar.Text);
        }


        //========================================
        private void AbirFormEpreencherOsCampos()
        {
            var id = SelecionarColaboradorModel();
            var colaborador = ColaboradorAlterarController.Buscar(id);
            AbrirFormAlterar(colaborador);
            
        }
        private int SelecionarColaboradorModel() => Convert.ToInt32(dgvLista.SelectedRows[0].Cells[0].Value);


    }
}