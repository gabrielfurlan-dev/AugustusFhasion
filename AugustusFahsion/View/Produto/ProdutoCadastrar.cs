using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.View
{

    public partial class ProdutoCadastrar : Form
    {
        private ProdutoCadastrarController _controller;
        private ProdutoModel produtoModel;
        public ProdutoCadastrar(ProdutoCadastrarController produtoCadastrarController)
        {
            InitializeComponent();
            _controller = produtoCadastrarController;
            produtoModel = new ProdutoModel { };
        }

        private void btnEnviar_Click(object sender, System.EventArgs e)
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


                    _controller.CadastrarProduto(produtoModel);
                    this.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao tentar gravar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
