using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.View.Listar
{
    public partial class FrmProdutoListar : Form
    {
        private ProdutoListarController _controller;
        public FrmProdutoListar(ProdutoListarController produtoListarController)
        {
            InitializeComponent();
            _controller = produtoListarController;
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var id = SelecionarProdutoModel();
            var produto = ProdutoAlterarController.Buscar(id);
            AbrirFormAlterar(produto);
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (Validacoes.EhNumerico(txtProcurar.Text))
            {
                dgvLista.DataSource = _controller.ListarProdutosPorId(int.Parse(txtProcurar.Text));
            }
            else if (txtProcurar.Text == "%")
            {
                dgvLista.DataSource = _controller.ListarProdutos();
            }
            else
            {
                dgvLista.DataSource = _controller.ListarProdutosPorNome(txtProcurar.Text);
            }
        }

        private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = SelecionarProdutoModel();
            var produto = ProdutoAlterarController.Buscar(id);
            AbrirFormAlterar(produto);
        }

        private int SelecionarProdutoModel()
        {
            return Convert.ToInt32(dgvLista.SelectedRows[0].Cells[0].Value);
        }

        private void AbrirFormAlterar(ProdutoModel produto)
        {
            new ProdutoAlterarController().AbrirFormulario(produto);
            this.Close();
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAlterar.Enabled = true;
        }
    }
}
