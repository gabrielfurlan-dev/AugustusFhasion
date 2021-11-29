using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.View
{

    public partial class FrmProdutoCadastrar : Form
    {
        private ProdutoCadastrarController _controller;
        private ProdutoModel produtoModel;
        public FrmProdutoCadastrar(ProdutoCadastrarController produtoCadastrarController)
        {
            InitializeComponent();
            _controller = produtoCadastrarController;
            produtoModel = new ProdutoModel { };
        }


        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            {
                try
                {

                    if (String.IsNullOrEmpty(txtNome.Text))
                    {
                        MessageBox.Show("Insira um nome.");
                        return;
                    }
                    if (String.IsNullOrEmpty(txtFabricante.Text))
                    {
                        MessageBox.Show("Insira uma marca");
                        return;
                    }
                    if (nupPrecoCusto.Value < 0)
                    {
                        MessageBox.Show("Insira um preço de custo válido");
                        return;
                    }
                    if (nupPrecoVenda.Value < 0)
                    {
                        MessageBox.Show("Insira um preço de venda válido");
                        return;
                    }
                                        
                    produtoModel.Nome = txtNome.Text;
                    produtoModel.Fabricante = txtFabricante.Text;
                    produtoModel.PrecoCusto = nupPrecoCusto.Value;
                    produtoModel.PrecoVenda = nupPrecoVenda.Value;
                    produtoModel.CodigoBarras = mtxtCodigoBarras.Text;
                    produtoModel.QuantidadeEstoque = (int)nupQuantidadeEstoque.Value;
                    produtoModel.Condicao = cbCondicao.Text;

                    _controller.CadastrarProduto(produtoModel);
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao tentar gravar");
                }
            }
        }
    }
}
