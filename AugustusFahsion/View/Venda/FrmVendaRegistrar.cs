using AugustusFahsion.Controller;
using AugustusFahsion.Controller.Venda;
using AugustusFahsion.Model;
using AugustusFahsion.Model.Venda;
using System;
using System.Collections.Generic;
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

        public FrmVendaRegistrar()
        {
            InitializeComponent();
        }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


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
            lblIdProduto.Text = produto.IdProduto.ToString();
            lblProdutoSelecionado.Text = produto.Nome;
            lblPrecoProduto.Text = produto.PrecoVenda.ToString();
            lblTotalProdutoSemDesconto.Text = (Convert.ToDecimal(produto.PrecoVenda) * nupQuantidade.Value).ToString();
            lblTotalProdutoComDesconto.Text = (Convert.ToDecimal(produto.PrecoVenda) * nupQuantidade.Value).ToString();
            AtualizarPrecosProdutoSelecionado();
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
        private void dgvCarrinho_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) => 
            SelecionarCarrinhoModel();

        //atualizar preços
        private void nupQuantidade_ValueChanged(object sender, EventArgs e) => AtualizarPrecosProdutoSelecionado();
        private void nupDesconto_KeyUp(object sender, KeyEventArgs e) => AtualizarPrecosProdutoSelecionado(); 

        private void nupDesconto_ValueChanged(object sender, EventArgs e) => AtualizarPrecosProdutoSelecionado();
        private void nupQuantidade_KeyUp(object sender, KeyEventArgs e) => AtualizarPrecosProdutoSelecionado();


        //funções do carinhho
        List<CarrinhoModel> CarrinhoLista = new List<CarrinhoModel>();
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (lblProdutoSelecionado.Text.Equals("Selecione um produto. . ."))
                MessageBox.Show("Selecione um produto primeiro.");
            else if (nupQuantidade.Value < 1)
                MessageBox.Show("Informe a quantidade");
            else 
            {
                var desconto = TotalDesconto();
                    
                CarrinhoLista.Add(new CarrinhoModel() {
                    IdProdutoGuid =  Guid.NewGuid(),
                    IdProduto = lblIdProduto.Text.IntOuZero(),
                    NomeProduto = lblProdutoSelecionado.Text, 
                    Quantidade = Convert.ToInt32(nupQuantidade.Value),
                    Desconto = (int)nupDesconto.Value,
                    PrecoLiquido = desconto,
                    PrecoVenda = lblPrecoProduto.Text.RealParaDecimal(),
                    total = lblTotalProdutoSemDesconto.Text.RealParaDecimal()
                });

                AtualizarCarrinho();
                AtualizarPrecosCarinho();
            }
        }
        private void btnRemover(object sender, EventArgs e)
        {
            int selecionado = Convert.ToInt32(dgvCarrinho.SelectedRows[0].Index);
            CarrinhoLista.RemoveAt(selecionado);

            AtualizarCarrinho();
            AtualizarPrecosCarinho();
        }


        //=====================================================================================
        //selecionar Model
        public int SelecionarClienteModel() => Convert.ToInt32(dgvClienteListar.SelectedRows[0].Cells[0].Value);
        public int SelecionarColaboradorModel() => Convert.ToInt32(dgvColaboradorListar.SelectedRows[0].Cells[0].Value);
        public int SelecionarProdutoModel() => Convert.ToInt32(dgvProdutoListar.SelectedRows[0].Cells[0].Value);
        public string SelecionarCarrinhoModel() => dgvCarrinho.SelectedRows[0].Cells[7].Value.ToString();

        //Metodos atualizar precos
        private decimal ValorTotalProdutoSemDesconto()
        {
            return Convert.ToDecimal(lblPrecoProduto.Text) * Convert.ToDecimal(nupQuantidade.Value);
        }
        private decimal ValorTotalProdutoComDesconto()
        {
            return ValorTotalProdutoSemDesconto() - TotalDesconto();
        }
        private decimal TotalDesconto() 
        { 
            return ValorTotalProdutoSemDesconto() - (ValorTotalProdutoSemDesconto() * 
            (Convert.ToDecimal(nupDesconto.Value) * Convert.ToDecimal(0.01)));
        }
        private void AtualizarPrecosProdutoSelecionado()
        {
            lblTotalProdutoSemDesconto.Text = ValorTotalProdutoSemDesconto().ToString("c");
            lblTotalProdutoComDesconto.Text = TotalDesconto().ToString("c");
            lblTotalDescontoProduto.Text = ValorTotalProdutoComDesconto().ToString("c");

        }
        public void AtualizarPrecosCarinho() {
            lblTotalBruto.Text = _vendaModel.TotalBruto.ToString("c");
            lblTotalLiquido.Text = _vendaModel.TotalLiquido.ToString("c");
            lblTotalDesconto.Text = _vendaModel.TotalDesconto.ToString("c");
        }
        private void AtualizarCarrinho()
        {
            dgvCarrinho.DataSource = null;
            dgvCarrinho.DataSource = CarrinhoLista;
        }

        //atribuir campos para model
        public void AtribuirCamposVendaModel() 
        {
            _vendaRegistrarController = new VendaRegistrarController();
            _vendaModel.IdColaborador = Convert.ToInt32(lblIdColaborador.Text);
            _vendaModel.IdCliente = Convert.ToInt32(lblIdCliente.Text);
            _vendaModel.FormaPagamento = cbFormaPagamento.Text;
            _vendaModel.TotalBruto = lblTotalBruto.Text.RealParaDecimal();
            _vendaModel.TotalLiquido = lblTotalLiquido.Text.RealParaDecimal();
            _vendaModel.TotalDesconto = lblTotalDesconto.Text.RealParaDecimal();
        }
        public void AtribuirCamposVendaProdutoModel() 
        {
            foreach (var item in CarrinhoLista)
            {
                _vendaProdutoModel = new VendaProdutoModel();
                _vendaProdutoModel.IdProdutoGuid = item.IdProdutoGuid;
                _vendaProdutoModel.IdProduto = item.IdProduto;
                _vendaProdutoModel.PrecoVenda = item.PrecoVenda;
                _vendaProdutoModel.Quantidade = item.Quantidade;
                _vendaProdutoModel.PrecoLiquido = item.PrecoLiquido;
                _vendaProdutoModel.Desconto = item.Desconto;
                _vendaProdutoModel.Total = item.total;
                _vendaModel.VendaProdutoModel.Add(_vendaProdutoModel);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
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
            if (CarrinhoLista.Count.Equals(0)) {
                MessageBox.Show("Selecione pelo menos 1 item ao seu carrinho");
                return;
            }
            if (String.IsNullOrEmpty(cbFormaPagamento.Text))
            {
                MessageBox.Show("Selecione uma forma de pagamento.");
                return;
            }

            AtribuirCamposVendaModel();
            AtribuirCamposVendaProdutoModel();

            _vendaRegistrarController.RegistrarVenda(_vendaModel);
        }
    }
}
