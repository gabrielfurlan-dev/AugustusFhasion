using AugustusFahsion.Controller;
using AugustusFahsion.Controller.Venda;
using AugustusFahsion.Model;
using AugustusFahsion.Model.Venda;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.View.Venda
{
    public partial class FrmVendaAlterar : Form
    {
        private VendaAlterarController _controllerAlterar;
        private VendaExcluirController _controllerExcluir;
        private VendaListarController _controllerVendaListar;
        private ProdutoListarController _produtoListarController;
        private VendaModel vendaModelSelecionada;
        public FrmVendaAlterar()
        {
            InitializeComponent();
        }
        public FrmVendaAlterar(VendaAlterarController vendaAlterarController, VendaModel vendaModel)
        {
            InitializeComponent();
            _controllerAlterar = vendaAlterarController;
            vendaModelSelecionada = vendaModel;

            AtribuirModelParaCampos(vendaModel);
            _controllerExcluir = new VendaExcluirController();
            _produtoListarController = new ProdutoListarController();
            _controllerVendaListar = new VendaListarController();
        }

        public void AtribuirModelParaCampos(VendaModel vendaModelSelecionada)
        {

            var id = vendaModelSelecionada.IdVenda;
            var vendaModel = _controllerAlterar.BuscarVenda(id);
            var vendaListagemModel = new VendaListarController().ListarVendaSelecionada(id);

            lblIdVenda.Text = vendaListagemModel[0].IdVenda.ToString();
            lblClienteSelecionado.Text = vendaListagemModel[0].NomeCliente;
            lblColaboradorSelecionado.Text = vendaListagemModel[0].NomeColaborador;
            lblTotalBruto.Text = vendaListagemModel[0].TotalBruto.ToString("c");
            lblTotalLiquido.Text = vendaListagemModel[0].TotalLiquido.ToString("c");
            lblTotalDesconto.Text = vendaListagemModel[0].TotalDesconto.ToString("c");
            cbFormaPagamento.Text = vendaListagemModel[0].FormaPagamento;
            lblIdCliente.Text = vendaModel.IdCliente.ToString();
            lblIdColaborador.Text = vendaModel.IdColaborador.ToString();
        }

        public VendaModel SelecionarVendaModel(int id) => _controllerAlterar.BuscarVenda(id);
        

        private void btnExcluirVenda_Click(object sender, EventArgs e)
        {
            //_controllerExcluir.ExcluirVenda(vendaModel);
        }

        private void AtribuirValoresProdutoSelecionado(ProdutoModel produto)
        {
            lblIdProduto.Text = produto.IdProduto.ToString();
            lblProdutoSelecionado.Text = produto.Nome;
            lblPrecoProduto.Text = produto.PrecoVenda.ToString();
            lblTotalProdutoSemDesconto.Text = (Convert.ToDecimal(produto.PrecoVenda) * nupQuantidade.Value).ToString();
            lblTotalProdutoComDesconto.Text = (Convert.ToDecimal(produto.PrecoVenda) * nupQuantidade.Value).ToString();
            lblProdutoLucroUnitario.Text = (produto.PrecoVenda - produto.PrecoCusto).ToString();
            nupQuantidade.Maximum = produto.QuantidadeEstoque;
            CalcularPrecosProdutoSelecionado();
        }
        private void AtribuirValoresProdutosDoCarrinhoSelecionados(VendaProdutoModel vendaProdutoModel) 
        {
            lblIdProduto.Text = vendaProdutoModel.IdProduto.ToString();
            lblProdutoSelecionado.Text = vendaProdutoModel.Nome;
            lblPrecoProduto.Text = vendaProdutoModel.PrecoVenda.ToString();
            lblTotalProdutoSemDesconto.Text = (Convert.ToDecimal(vendaProdutoModel.PrecoVenda) * nupQuantidade.Value).ToString();
            lblTotalProdutoComDesconto.Text = (Convert.ToDecimal(vendaProdutoModel.PrecoVenda) * nupQuantidade.Value).ToString();
            //lblProdutoLucroUnitario.Text = (vendaProdutoModel.PrecoVenda - vendaProdutoModel.PrecoCusto).ToString();
            CalcularPrecosProdutoSelecionado();
        }

        private void CalcularPrecosProdutoSelecionado()
        {
            lblTotalProdutoSemDesconto.Text = ValorTotalBrutoProduto().ToString("c");
            lblTotalProdutoComDesconto.Text = ValorTotalDesconto().ToString("c");
            lblTotalDescontoProduto.Text = ValorTotalDescontoProduto().ToString("c");
            lblProdutoLucroUnitario.Text = ValorProdutoLucro().ToString("c");
        }


        private decimal ValorTotalBrutoProduto() =>
            Convert.ToDecimal(lblPrecoProduto.Text) * nupQuantidade.Value;
        private decimal ValorTotalDescontoProduto() =>
            ValorTotalBrutoProduto() - ValorTotalDesconto();
        private decimal ValorProdutoLucro() =>
            (Convert.ToDecimal(Extensoes.RealParaDecimal(lblProdutoLucroUnitario.Text)) * nupQuantidade.Value) - ValorTotalDescontoProduto();
        private decimal ValorTotalDesconto() =>
            ValorTotalBrutoProduto() - (ValorTotalBrutoProduto() * (Convert.ToDecimal(nupDesconto.Value) * Convert.ToDecimal(0.01)));
        public int SelecionarProdutoModel() =>
            Convert.ToInt32(dgvProdutoListar.SelectedRows[0].Cells[0].Value);

        public int SelecionarProdutoModelDoCarrinho() => Convert.ToInt32(dgvProdutosVenda.SelectedRows[0].Cells[0].Value);


        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();

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

        //Atualizar preços por ação
        private void nupQuantidade_KeyUp(object sender, KeyEventArgs e) => CalcularPrecosProdutoSelecionado();
        private void nupQuantidade_ValueChanged(object sender, EventArgs e) => CalcularPrecosProdutoSelecionado();
        private void nupDesconto_ValueChanged(object sender, EventArgs e) => CalcularPrecosProdutoSelecionado();
        private void nupDesconto_KeyUp(object sender, KeyEventArgs e) => CalcularPrecosProdutoSelecionado();

        private void FrmVendaAlterar_Load(object sender, EventArgs e) =>
            dgvProdutosVenda.DataSource = _controllerVendaListar.ListarProdutosDaVenda(Convert.ToInt32(lblIdVenda.Text));

        private void dgvProdutoListar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = SelecionarProdutoModel();
            var produto = ProdutoAlterarController.Buscar(id);

            AtribuirValoresProdutoSelecionado(produto);
            CalcularPrecosProdutoSelecionado();
        }

        private void dgvProdutosVenda_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var idSelecionado = SelecionarProdutoModelDoCarrinho();
            var produtoDoCarrinhoSelecionado = _controllerAlterar.BuscarDadosDoProdutoDaVenda(idSelecionado);

            AtribuirValoresProdutosDoCarrinhoSelecionados(produtoDoCarrinhoSelecionado);
            CalcularPrecosProdutoSelecionado();
        }
    }
}
