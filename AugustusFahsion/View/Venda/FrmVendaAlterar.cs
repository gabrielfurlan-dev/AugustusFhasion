using AugustusFahsion.Controller;
using AugustusFahsion.Controller.Venda;
using AugustusFahsion.Model;
using AugustusFahsion.Model.Venda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AugustusFahsion.View.Venda
{
    public partial class FrmVendaAlterar : Form
    {
        private VendaAlterarController _controllerVendaAlterar;
        private VendaListarController _controllerVendaListar;
        private ProdutoListarController _produtoListarController;
        private VendaModel _vendaModelSelecionada;
        private VendaRegistrarController _vendaRegistrarController;
        private int _quantidadeOriginal = 0;
        private int _estoqueOriginal = 0;
        public FrmVendaAlterar()
        {
            InitializeComponent();
        }
        public FrmVendaAlterar(VendaAlterarController vendaAlterarController, VendaModel vendaModel)
        {
            InitializeComponent();
            _controllerVendaAlterar = vendaAlterarController;
            _vendaModelSelecionada = vendaModel;

            AtribuirModelParaCampos(vendaModel);
            _produtoListarController = new ProdutoListarController();
            _controllerVendaListar = new VendaListarController();
            _vendaRegistrarController = new VendaRegistrarController();

        }

        private void FrmVendaAlterar_Load(object sender, EventArgs e)
        {
            AdicionarProdutosRegistradosDaVendaNaLista();
            AtualizarCarrinho();
        }
        
        //dgv_cellMouseClick
        private void dgvProdutoListar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = SelecionarProdutoModel();
            var produto = ProdutoAlterarController.Buscar(id);

            AtribuirValoresProdutoSelecionado(produto);
            CalcularPrecosProdutoSelecionado();
        }
        private void dgvProdutosVenda_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AtribuirValoresProdutosDoCarrinhoSelecionados();
            CalcularPrecosProdutoSelecionado();
        }

        //Atualizar preços por ação
        private void nupQuantidade_KeyUp(object sender, KeyEventArgs e) => CalcularPrecosProdutoSelecionado();
        private void nupQuantidade_ValueChanged(object sender, EventArgs e) => CalcularPrecosProdutoSelecionado();
        private void nupDesconto_ValueChanged(object sender, EventArgs e) => CalcularPrecosProdutoSelecionado();
        private void nupDesconto_KeyUp(object sender, KeyEventArgs e) => CalcularPrecosProdutoSelecionado();
        private void cbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFormaPagamento.Text != "A prazo") cbPago.Visible = false;
            if (cbFormaPagamento.Text == "A prazo") cbPago.Visible = true;
        }

        public VendaModel SelecionarVendaModel(int id) => VendaAlterarController.BuscarVenda(id);

        //atribuir Valores
        public void AtribuirModelParaCampos(VendaModel vendaModelSelecionada)
        {
            var id = vendaModelSelecionada.IdVenda;
            var vendaModel = VendaAlterarController.BuscarVenda(id);
            var vendaListagemModel = new VendaListarController().ListarVendaSelecionada(id);

            lblIdVenda.Text = vendaListagemModel[0].IdVenda.ToString();
            lblClienteSelecionado.Text = vendaListagemModel[0].NomeCliente;
            lblColaboradorSelecionado.Text = vendaListagemModel[0].NomeColaborador;
            lblTotalBruto.Text = vendaListagemModel[0].TotalBruto.ValorFormatado;
            lblTotalLiquido.Text = vendaListagemModel[0].TotalLiquido.ValorFormatado;
            lblTotalDesconto.Text = vendaListagemModel[0].TotalDesconto.ValorFormatado;
            cbFormaPagamento.Text = vendaListagemModel[0].FormaPagamento;
            if (vendaListagemModel[0].Pago == true) { cbPago.Text = "Sim"; } else { cbPago.Text = "Não"; }
            if (cbFormaPagamento.Text != "A prazo") 
            { 
                cbPago.Visible = false;
            }
            
            lblIdCliente.Text = vendaModel.Cliente.IdCliente.ToString();
            lblIdColaborador.Text = vendaModel.IdColaborador.ToString();
        }
        private void AtribuirValoresProdutoSelecionado(ProdutoModel produto)
        {
            lblIdProduto.Text = produto.IdProduto.ToString();
            lblProdutoSelecionado.Text = produto.Nome;
            lblPrecoProduto.Text = produto.PrecoVenda.ValorFormatado;
            lblTotalBrutoProduto.Text = (produto.PrecoVenda.RetornarValor * nupQuantidade.Value).ToString();
            lblTotalLiquidoProduto.Text = (produto.PrecoVenda.RetornarValor * nupQuantidade.Value).ToString();
            CalcularPrecosProdutoSelecionado();
        }
        private void AtribuirValoresProdutosDoCarrinhoSelecionados()
        {
            lblIdProduto.Text = dgvProdutosVenda.SelectedRows[0].Cells[0].Value.ToString();
            lblProdutoSelecionado.Text = dgvProdutosVenda.SelectedRows[0].Cells[1].Value.ToString();
            lblPrecoProduto.Text = dgvProdutosVenda.SelectedRows[0].Cells[3].Value.ToString();
            nupQuantidade.Value = Convert.ToDecimal(dgvProdutosVenda.SelectedRows[0].Cells[4].Value);
            lblTotalBrutoProduto.Text = dgvProdutosVenda.SelectedRows[0].Cells[5].ToString();
            nupDesconto.Value = Convert.ToDecimal(dgvProdutosVenda.SelectedRows[0].Cells[6].Value);
            lblTotalLiquidoProduto.Text = dgvProdutosVenda.SelectedRows[0].Cells[7].ToString();
            CalcularPrecosProdutoSelecionado();
        }
        private decimal ValorTotalBrutoProduto() =>
            Extensoes.RealParaDecimal(lblPrecoProduto.Text) * nupQuantidade.Value;
        private decimal ValorTotalDescontoProduto() =>
            ValorTotalBrutoProduto() - ValorTotalDesconto();
        private decimal ValorTotalDesconto() =>
            ValorTotalBrutoProduto() - (ValorTotalBrutoProduto() * nupDesconto.Value * Convert.ToDecimal(0.01));
        public int SelecionarProdutoModel() 
        { 
            int idProduto = Convert.ToInt32(dgvProdutoListar.SelectedRows[0].Cells[0].Value);
            setarQuantidadeEstoqueMaximum(idProduto, Convert.ToInt32(lblIdVenda.Text));
            return idProduto;
        }

        public int SelecionarProdutoModelDoCarrinho() =>
            Convert.ToInt32(dgvProdutosVenda.SelectedRows[0].Cells[0].Value);

        private void CalcularPrecosProdutoSelecionado()
        {
            lblTotalBrutoProduto.Text = ValorTotalBrutoProduto().ToString("c");
            lblTotalLiquidoProduto.Text = ValorTotalDesconto().ToString("c");
            lblTotalDescontoProduto.Text = ValorTotalDescontoProduto().ToString("c");
        }
        private void setarQuantidadeEstoqueMaximum(int idProduto, int idVenda)
        {
            _quantidadeOriginal = VendaAlterarController.BuscarQuantidadeOriginalDaVenda(idProduto, idVenda);
            _estoqueOriginal = VendaAlterarController.BuscarEstoqueOriginal(idProduto);
            nupQuantidade.Maximum = _quantidadeOriginal + _estoqueOriginal;
        }

        //funções do carrinho
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (lblProdutoSelecionado.Text.Equals("Selecione um produto. . ."))
            {
                MessageBox.Show("Selecione um produto primeiro.");
                return;
            }
            if (nupQuantidade.Value < 1)
            {
                MessageBox.Show("Informe a quantidade");
                return;
            }
            var produto = VerificarSeExisteNoCarrinho(Convert.ToInt32(lblIdProduto.Text));
            if (produto != null)
            {
                var index = _vendaModelSelecionada.ListaDeItens.IndexOf(produto);

                CalcularPrecosProdutoSelecionado();
                _vendaModelSelecionada.ListaDeItens[index].Quantidade = Convert.ToInt32(nupQuantidade.Value);
                _vendaModelSelecionada.ListaDeItens[index].Desconto = Convert.ToInt32(nupDesconto.Value);
                _vendaModelSelecionada.ListaDeItens[index].TotalLiquido = Extensoes.RealParaDecimal(lblTotalLiquidoProduto.Text);

                AtualizarCarrinho();
                AtualizarPrecosTotais();
                return;
            }

            AdicionarProdutoNoCarrinho();
            AtualizarCarrinho();
            AtualizarPrecosTotais();
        }
        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            int selecionado = Convert.ToInt32(dgvProdutosVenda.SelectedRows[0].Index);
            _vendaModelSelecionada.ListaDeItens.RemoveAt(selecionado);

            AtualizarCarrinho();
            AtualizarPrecosTotais();
        }

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


        public void AdicionarProdutoNoCarrinho()
        {
            var desconto = ValorTotalDesconto();

            _vendaModelSelecionada.ListaDeItens.Add(new VendaProdutoModel()
            {
                IdProdutoGuid = Guid.NewGuid(),
                IdProduto = lblIdProduto.Text.IntOuZero(),
                IdVenda = Convert.ToInt32(lblIdVenda.Text),
                Nome = lblProdutoSelecionado.Text,
                Quantidade = Convert.ToInt32(nupQuantidade.Value),
                Desconto = (int)nupDesconto.Value,
                TotalLiquido = desconto,
                PrecoVenda = lblPrecoProduto.Text.RealParaDecimal(),
                TotalBruto = lblTotalLiquidoProduto.Text.RealParaDecimal(),
                //Lucro = lblLucroProduto.Text.RealParaDecimal()
            }) ;
        }
        public void AdicionarProdutosRegistradosDaVendaNaLista()
        {
            List<VendaProdutoModel> itensDaVenda = _controllerVendaListar.ListarProdutosDaVenda(Convert.ToInt32(lblIdVenda.Text));
            foreach (var item in itensDaVenda)
            {
                _vendaModelSelecionada.ListaDeItens.Add(new VendaProdutoModel()
                {
                    IdProdutoGuid = item.IdProdutoGuid,
                    IdVenda = item.IdVenda,
                    IdProduto = item.IdProduto,
                    Nome = item.Nome,
                    Quantidade = item.Quantidade,
                    Desconto = item.Desconto,
                    TotalLiquido = item.TotalLiquido,
                    PrecoVenda = item.PrecoVenda,
                    TotalBruto = item.TotalBruto,
                    Lucro = item.Lucro
                });
            }
        }
        private void AtualizarPrecosTotais()
        {
            //lblTotalBrutoVenda.Text = _vendaModel.TotalBruto.ToString("c");
            //lblTotalLiquido.Text = _vendaModel.TotalLiquido.ToString("c");
            //lblTotalDesconto.Text = _vendaModel.TotalDesconto.ToString("c");
            //lblTotalLucro.Text = _vendaModel.TotalLucro.ToString("c");
        }
        private void AtualizarCarrinho()
        {
            dgvProdutosVenda.DataSource = null;
            dgvProdutosVenda.DataSource = _vendaModelSelecionada.ListaDeItens;
        }

        public VendaProdutoModel VerificarSeExisteNoCarrinho(int id) => 
            (from x in _vendaModelSelecionada.ListaDeItens where x.IdProduto == id select x).FirstOrDefault();

        private void BtnInativarVenda_Click(object sender, EventArgs e)
        {
            //var vendaSelecionada = _controllerVendaAlterar.BuscarVenda(Convert.ToInt32(lblIdVenda.Text));
            VendaAlterarController.InativarVenda(_vendaModelSelecionada);
            MessageBox.Show("Venda Inativada.");
            this.Close(); 
        }

        private void btnSalvarAlteracoes_Click(object sender, EventArgs e)
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
            if (_vendaModelSelecionada.ListaDeItens.Count.Equals(0))
            {
                MessageBox.Show("Selecione pelo menos 1 item ao seu carrinho");
                return;
            }
            if (String.IsNullOrEmpty(cbFormaPagamento.Text))
            {
                MessageBox.Show("Selecione uma forma de pagamento.");
                return;
            }
            if (cbPago.Text == "Sim")
                _vendaModelSelecionada.Pago = 1;


            AlterarVenda();
            this.Close();
        }
        private void AlterarVenda()
        {
            VendaAlterarController.AlterarVenda(_vendaModelSelecionada);
            MessageBox.Show("Venda Alterada!");
        }

    }
}
