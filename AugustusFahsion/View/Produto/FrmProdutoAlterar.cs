﻿using AugustusFahsion.Controller;
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AtribuirModelParaCampos(ProdutoModel produto)
        {
            txtId.Text = produto.IdProduto.ToString();
            txtNome.Text = produto.Nome;
            txtFabricante.Text = produto.Fabricante;
            nupPrecoCusto.Value = (decimal)produto.PrecoCusto;
            nupPrecoVenda.Value = (decimal)produto.PrecoVenda;
            nupQuantidadeEstoque.Value = produto.QuantidadeEstoque;
            mtxtCodigoBarras.Text = produto.CodigoBarras;
            cbCondicao.Text = produto.Condicao;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
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
                    produtoModel.CodigoBarras = mtxtCodigoBarras.Text;
                    produtoModel.QuantidadeEstoque = (int)nupQuantidadeEstoque.Value;
                    produtoModel.CodigoBarras = cbCondicao.Text;

                    _controllerAlterar.AtualizarProduto(produtoModel);
                    this.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao tentar gravar");
            }
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
    }
}
