﻿using AugustusFahsion.Controller;
using AugustusFahsion.Controller.Venda;
using AugustusFahsion.Model;
using AugustusFahsion.Model.Venda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AugustusFahsion.View.Venda
{
    public partial class FrmVendaRegistrar : Form
    {
        VendaRegistrarController _controllerRegistrar;
        ClienteListarController _clienteListarController;
        ColaboradorListarController _colaboradorListarController;
        ProdutoListarController _produtoListarController;
        VendaProdutoModel _vendaProdutoModel;
        VendaModel _vendaModel;
        VendaRegistrarController _vendaRegistrarController;

        public FrmVendaRegistrar() => InitializeComponent();
        public FrmVendaRegistrar(VendaRegistrarController vendaRegistrarController)
        {
            InitializeComponent();
            _controllerRegistrar = vendaRegistrarController;
            _clienteListarController = new ClienteListarController();
            _colaboradorListarController = new ColaboradorListarController();
            _produtoListarController = new ProdutoListarController();
            _vendaModel = new VendaModel();
            _vendaProdutoModel = new VendaProdutoModel();
        }

        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();


        //Botoes de Busca
        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            if (Validacoes.EhNumerico(txtProcurar.Text))
            {
                dgvClienteListar.DataSource = _clienteListarController.ListarClientesPorId(int.Parse(txtPesquisarCliente.Text));
            }
            else if (txtProcurar.Text == "%")
            {
                dgvClienteListar.DataSource = _clienteListarController.ListarClientes();
            }
            else
            {
                dgvClienteListar.DataSource = _clienteListarController.ListarClientesPorNome(txtPesquisarCliente.Text);
            }
        }
        private void btnPesquisarColaborador_Click(object sender, EventArgs e)
        {
            if (Validacoes.EhNumerico(txtProcurar.Text))
            {
                dgvColaboradorListar.DataSource = _colaboradorListarController.ListarColaboradorPorId(int.Parse(txtPesquisarCliente.Text));
            }
            else if (txtProcurar.Text == "%")
            {
                dgvColaboradorListar.DataSource = _colaboradorListarController.ListarColaborador();
            }
            else
            {
                dgvColaboradorListar.DataSource = _colaboradorListarController.ListarColaboradorPorNome(txtPesquisarCliente.Text);
            }
        }
        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            if (Validacoes.EhNumerico(txtProcurar.Text))
                dgvProdutoListar.DataSource = 
                    _produtoListarController.ListarProdutosAtivosPorId(int.Parse(txtProcurar.Text));
            
            else if (txtProcurar.Text == "%")
                dgvProdutoListar.DataSource = 
                    _produtoListarController.ListarProdutosAtivos();
            else
                dgvProdutoListar.DataSource = 
                    _produtoListarController.ListarProdutosAtivosPorNome(txtProcurar.Text);
        }


        //DvgCellMouseCLick
        private void dgvProdutoListar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = SelecionarProdutoModel();
            var produto = ProdutoAlterarController.Buscar(id);
            AtribuirValoresDoProdutoSelecionado(produto);
            CalcularPrecosProdutoSelecionado();
        }
        private void dgvClienteListar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = SelecionarClienteModel();
            var cliente = ClienteAlterarController.Buscar(id);
            lblIdCliente.Text = id.ToString();
            lblClienteSelecionado.Text = cliente.NomeCompleto.ToString();
        }
        private void dgvColaboradorListar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = SelecionarColaboradorModel();
            var colaborador = ColaboradorAlterarController.Buscar(id);
            lblIdColaborador.Text = id.ToString();
            lblColaboradorSelecionado.Text = colaborador.NomeCompleto.ToString();
        }
        private void dgvCarrinho_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) => SelecionarCarrinhoModel();

        //atualizar preços por ação
        private void NupQuantidade_ValueChanged(object sender, EventArgs e) => CalcularPrecosProdutoSelecionado();
        private void NupDesconto_KeyUp(object sender, KeyEventArgs e) => CalcularPrecosProdutoSelecionado(); 
        private void NupDesconto_ValueChanged(object sender, EventArgs e) => CalcularPrecosProdutoSelecionado();
        private void NupQuantidade_KeyUp(object sender, KeyEventArgs e) => CalcularPrecosProdutoSelecionado();

        //funções do carinhho
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (lblProdutoSelecionado.Text.Equals("Selecione um produto. . ."))
            { 
                MessageBox.Show("Selecione um produto primeiro.");
                return;
            }
            if (nupQuantidade.Value < 1) { 
                MessageBox.Show("Informe a quantidade");
                return;
            }
            var produto = VerificarSeExisteNoCarrinho(SelecionarProdutoModel());
            if (produto != null) 
            {
                var index = _vendaModel.ListaDeItens.IndexOf(produto);

                _vendaModel.ListaDeItens[index].Quantidade = Convert.ToInt32(nupQuantidade.Value);
                _vendaModel.ListaDeItens[index].Desconto = Convert.ToInt32(nupDesconto.Value);
                AtualizarCarrinho();
                AtualizarPrecosTotais();
                return;
            }

            AdicionarProdutoNoCarrinho();
            AtualizarCarrinho();
            AtualizarPrecosTotais();
        }
        private void BtnRemover(object sender, EventArgs e)
        {
            int selecionado = Convert.ToInt32(dgvCarrinho.SelectedRows[0].Index);
            _vendaModel.ListaDeItens.RemoveAt(selecionado);

            AtualizarCarrinho();
            AtualizarPrecosTotais();
        }
        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (lblClienteSelecionado.Text.Equals("Selecione um cliente. . ."))
            {
                MessageBox.Show("Selecione um cliente");
                return;
            }
            if (lblColaboradorSelecionado.Text.Equals("Selecione um colaborador. . ."))
            {
                MessageBox.Show("Selecione um colaborador");
                return;
            }
            if (_vendaModel.ListaDeItens.Count.Equals(0)) {
                MessageBox.Show("Selecione pelo menos 1 item ao seu carrinho");
                return;
            }
            if (String.IsNullOrEmpty(cbFormaPagamento.Text))
            {
                MessageBox.Show("Selecione uma forma de pagamento.");
                return;
            }

            RegistrarVenda();
            MessageBox.Show("Venda Registrada");
        }

        //selecionar Model
        public int SelecionarClienteModel() => 
            Convert.ToInt32(dgvClienteListar.SelectedRows[0].Cells[0].Value);
        public int SelecionarColaboradorModel() => 
            Convert.ToInt32(dgvColaboradorListar.SelectedRows[0].Cells[0].Value);
        public int SelecionarProdutoModel() => 
            Convert.ToInt32(dgvProdutoListar.SelectedRows[0].Cells[0].Value);
        public string SelecionarCarrinhoModel() => 
            dgvCarrinho.SelectedRows[0].Cells[7].Value.ToString();

        //atualizar precos
        private decimal ValorTotalBrutoProduto() =>
            Convert.ToDecimal(lblPrecoProduto.Text) * nupQuantidade.Value;
        private decimal ValorTotalDescontoProduto() => 
            ValorTotalBrutoProduto() - ValorTotalDesconto();
        private decimal ValorProdutoLucro() => 
            (Convert.ToDecimal(lblProdutoLucroUnitario.Text) * nupQuantidade.Value) - ValorTotalDescontoProduto();
        private decimal ValorTotalDesconto() => 
            ValorTotalBrutoProduto() - (ValorTotalBrutoProduto() * (Convert.ToDecimal(nupDesconto.Value) * Convert.ToDecimal(0.01)));
        private void CalcularPrecosProdutoSelecionado()
        {
            lblTotalProdutoSemDesconto.Text = ValorTotalBrutoProduto().ToString("c");
            lblTotalProdutoComDesconto.Text = ValorTotalDesconto().ToString("c");
            lblTotalDescontoProduto.Text = ValorTotalDescontoProduto().ToString("c");
            lblLucroProduto.Text = ValorProdutoLucro().ToString("c");
        }
        private void AtualizarCarrinho()
        {
            dgvCarrinho.DataSource = null;
            dgvCarrinho.DataSource = _vendaModel.ListaDeItens;
        }
        private void AtualizarPrecosTotais() {
            lblTotalBrutoVenda.Text = _vendaModel.TotalBruto.ToString("c");
            lblTotalLiquido.Text = _vendaModel.TotalLiquido.ToString("c");
            lblTotalDesconto.Text = _vendaModel.TotalDesconto.ToString("c");
            lblTotalLucro.Text = _vendaModel.TotalLucro.ToString("c");
        }

        private void AtribuirValoresDoProdutoSelecionado(ProdutoModel produto)
        {
            lblIdProduto.Text = produto.IdProduto.ToString();
            lblProdutoSelecionado.Text = produto.Nome;
            lblPrecoProduto.Text = produto.PrecoVenda.ToString();
            lblTotalProdutoSemDesconto.Text = (Convert.ToDecimal(produto.PrecoVenda) * nupQuantidade.Value).ToString();
            lblTotalProdutoComDesconto.Text = (Convert.ToDecimal(produto.PrecoVenda) * nupQuantidade.Value).ToString();
            lblProdutoLucroUnitario.Text = (produto.PrecoVenda - produto.PrecoCusto).ToString();
            nupQuantidade.Maximum = produto.QuantidadeEstoque;
        }
        public void RegistrarVenda() 
        {
            _vendaRegistrarController = new VendaRegistrarController();
            _vendaModel.IdColaborador = Convert.ToInt32(lblIdColaborador.Text);
            _vendaModel.IdCliente = Convert.ToInt32(lblIdCliente.Text);
            _vendaModel.FormaPagamento = cbFormaPagamento.Text;

            _vendaRegistrarController.RegistrarVenda(_vendaModel);

        }
        public void AdicionarProdutoNoCarrinho() {
            var desconto = ValorTotalDesconto();

            _vendaModel.ListaDeItens.Add(new VendaProdutoModel()
            {
                IdProdutoGuid = Guid.NewGuid(),
                IdProduto = lblIdProduto.Text.IntOuZero(),
                Nome = lblProdutoSelecionado.Text,
                Quantidade = Convert.ToInt32(nupQuantidade.Value),
                Desconto = (int)nupDesconto.Value,
                PrecoLiquido = desconto,
                PrecoVenda = lblPrecoProduto.Text.RealParaDecimal(),
                Total = lblTotalProdutoSemDesconto.Text.RealParaDecimal(),
                Lucro = lblLucroProduto.Text.RealParaDecimal()
            });
        }

        public VendaProdutoModel VerificarSeExisteNoCarrinho(int id) => 
            (from x in _vendaModel.ListaDeItens where x.IdProduto == id select x).FirstOrDefault();

        private void button2_Click(object sender, EventArgs e) => this.Close();
            
    }
}
