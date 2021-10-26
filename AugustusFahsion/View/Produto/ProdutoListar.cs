using AugustusFahsion.Controller;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.View.Listar
{
    public partial class ProdutoListar : Form
    {
        private ProdutoListarController _controller;
        public ProdutoListar(ProdutoListarController produtoListarController)
        {
            InitializeComponent();
            _controller = produtoListarController;
        }
        private void ProdutoListar_Load(object sender, EventArgs e)
        {
            dgvLista.DataSource = _controller.ListarProdutos();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
