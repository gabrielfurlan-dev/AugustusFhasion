using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.View.Alterar
{
    public partial class FrmProdutoAlterar : Form
    {
        private ProdutoAlterarController _controllerAlterar;
        private ProdutoExcluirController _controllerExcluir;
        private ProdutoModel produtoModel;
        public FrmProdutoAlterar(ProdutoAlterarController produtoAlterarController)
        {
            InitializeComponent();
            _controllerAlterar = produtoAlterarController;
            produtoModel = new ProdutoModel { };
        }

        public FrmProdutoAlterar(
            ProdutoAlterarController produtoAlterarController,
            ProdutoExcluirController produtoExcluirController,
            ProdutoModel produtoModelSelecionado
            )
        {
            InitializeComponent();
            _controllerAlterar = produtoAlterarController;
            produtoModel = produtoModelSelecionado;

            AtribuirModelParaCampos(produtoModel);
            _controllerExcluir = produtoExcluirController;
        }

        public void AtribuirModelParaCampos(ProdutoModel produto)
        {
            txtId.Text = produto.IdProduto.ToString();
            txtNome.Text = produto.Nome;
            txtFabricante.Text = produto.Fabricante;
            nupPrecoCusto.Value = produto.PrecoCusto.RetornarValor;
            nupPrecoVenda.Value = produto.PrecoVenda.RetornarValor;
            nupQuantidadeEstoque.Value = produto.QuantidadeEstoque;
            mtxtCodigoBarras.Text = produto.CodigoBarras;
            cbCondicao.Text = produto.Condicao;
        }

        private void PreencherCamposModel()
        {
            produtoModel.Nome = txtNome.Text;
            produtoModel.Fabricante = txtFabricante.Text;
            produtoModel.PrecoCusto = nupPrecoCusto.Value;
            produtoModel.PrecoVenda = nupPrecoVenda.Value;
            produtoModel.CodigoBarras = mtxtCodigoBarras.Text;
            produtoModel.QuantidadeEstoque = (int)nupQuantidadeEstoque.Value;
        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Insira um nome.");
                return false;
            }
            if (String.IsNullOrEmpty(txtFabricante.Text))
            {
                MessageBox.Show("Insira uma marca");
                return false;
            }
            if (nupPrecoCusto.Value < 0)
            {
                MessageBox.Show("Insira um preço de custo válido");
                return false;
            }
            if (nupPrecoVenda.Value < 0)
            {
                MessageBox.Show("Insira um preço de venda válido");
            }
            return true;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            if (ValidarCampos())

                PreencherCamposModel();

            _controllerAlterar.AtualizarProduto(produtoModel);
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
                    produtoModel.IdProduto = int.Parse(txtId.Text);
                    _controllerExcluir.ExcluirProduto(produtoModel);
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

        private void btnCancelar_Click_1(object sender, EventArgs e) => this.Close();
        private void btnFechar_Click_1(object sender, EventArgs e) => this.Close();
    }
}
