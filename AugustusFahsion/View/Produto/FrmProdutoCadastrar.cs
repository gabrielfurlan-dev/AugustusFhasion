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


        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {

            {
                try
                {

                    if (String.IsNullOrEmpty(txtNome.Text))
                    {
                        MessageBox.Show("Insira um nome.");
                    }
                    else if (String.IsNullOrEmpty(txtFabricante.Text))
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
                        produtoModel.Fabricante = txtFabricante.Text;
                        produtoModel.PrecoCusto = (double)nupPrecoCusto.Value;
                        produtoModel.PrecoVenda = (double)nupPrecoVenda.Value;
                        produtoModel.precoPromocao = (double)nupQuantidadeEstoque.Value;
                        produtoModel.CodigoBarras = mtxtCodigoBarras.Text;
                        produtoModel.QuantidadeEstoque = (int)nupQuantidadeEstoque.Value;
                        produtoModel.Condicao = cbCondicao.Text;


                        _controller.CadastrarProduto(produtoModel);
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
}
