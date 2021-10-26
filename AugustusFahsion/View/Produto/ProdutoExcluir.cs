using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.View.Excluir
{
    public partial class ProdutoExcluir : Form
    {
        private ProdutoExcluirController _controller;
        private ProdutoModel produtoModel;
        public ProdutoExcluir(ProdutoExcluirController produtoExcluirController)
        {
            InitializeComponent();
            _controller = produtoExcluirController;

            produtoModel = new ProdutoModel();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                Int32.TryParse(txtId.Text, out id);

                var validaID = new ProdutoExcluirController().ValidarId(id);
                if (id > 0 && validaID)
                {
                    produtoModel.Id = int.Parse(txtId.Text);
                    _controller.ExcluirProduto(produtoModel);
                    MessageBox.Show("Produto excluido com sucesso");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("id invalido!");
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
        }
    }
}
