using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.View.Alterar
{
    public partial class ProdutoAlterar : Form
    {
        private ProdutoAlterarController _controller;
        private ProdutoModel produtoModel;
        public ProdutoAlterar(ProdutoAlterarController produtoAlterarController)
        {
            InitializeComponent();
            _controller = produtoAlterarController;
            produtoModel = new ProdutoModel { };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarId_Click(object sender, EventArgs e)
        {
            int id;
            Int32.TryParse(txtId.Text, out id);

            var validaID = new ProdutoAlterarController().ValidarId(id);
            if (id > 0 && validaID)
            {
                produtoModel.Id = int.Parse(txtId.Text);
                MessageBox.Show("id válido!");
                produtoModel = _controller.Buscar(Int32.Parse(txtId.Text));


                txtNome.Text = produtoModel.Nome;
                txtMarca.Text = produtoModel.Marca;
                nupPrecoCusto.Value = (decimal)produtoModel.PrecoCusto;
                nupPrecoVenda.Value = (decimal)produtoModel.PrecoVenda;
                nupPrecoPromocao.Value = (decimal)produtoModel.precoPromocao;
                mtxtCodigoBarras.Text = produtoModel.CodigoBarras;

                btnSalvar.Enabled = true;
            }
            else
            {
                MessageBox.Show("id invalido!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(txtNome.Text))
                {
                    MessageBox.Show("Insira um nome.");
                }
                else if (String.IsNullOrEmpty(txtMarca.Text))
                {
                    MessageBox.Show("Insira uma marca");
                }
                else if (nupPrecoCusto.Value < 0)
                {
                    MessageBox.Show("Insira um preço de custo válido");
                }
                else if (nupPrecoVenda.Value < 0)
                {
                    MessageBox.Show("Insira um preço de venda válido");
                }
                else
                {
                    produtoModel.Nome = txtNome.Text;
                    produtoModel.Marca = txtMarca.Text;
                    produtoModel.PrecoCusto = (double)nupPrecoCusto.Value;
                    produtoModel.PrecoVenda = (double)nupPrecoVenda.Value;
                    produtoModel.precoPromocao = (double)nupPrecoPromocao.Value;
                    produtoModel.CodigoBarras = mtxtCodigoBarras.Text;

                    _controller.AtualizarProduto(produtoModel);
                    this.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao tentar gravar");
            }
        }
    }
}
