using AugustusFahsion.Controller;
using AugustusFahsion.Controller.Email;
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
        ClienteModel _cliente;
        ColaboradorModel _colaborador;

        ProdutoListarController _produtoListarController;
        VendaModel _vendaModel;
        VendaRegistrarController _vendaRegistrarController;
        ProdutoModel _produtoSelecionado;

        public FrmVendaRegistrar() => InitializeComponent();

        public FrmVendaRegistrar(VendaRegistrarController vendaRegistrarController)
        {
            InitializeComponent();
            _vendaRegistrarController = vendaRegistrarController;
            _produtoListarController = new ProdutoListarController();
            _vendaModel = new VendaModel();
        }

        private void BtnCancelar_Click(object sender, EventArgs e) => this.Close();

        private void BtAbrirSelecaoDeColaborador_Click(object sender, EventArgs e)
        {
            _colaborador = _vendaRegistrarController.ProcurarColaborador();
            if (_colaborador != null)
            {
                lblColaboradorSelecionado.Text = _colaborador.NomeCompleto.Nome + " " + _colaborador.NomeCompleto.Sobrenome;
                lblIdColaborador.Text = _colaborador.IdColaborador.ToString();
            }
        }

        private void BtnAbrirSelecaoDeCliente_Click(object sender, EventArgs e)
        {
            _vendaModel.Cliente = _vendaRegistrarController.ProcurarCliente();
            if (_vendaModel.Cliente != null)
            {
                lblClienteSelecionado.Text = _vendaModel.Cliente.NomeCompleto.Nome + " " + _vendaModel.Cliente.NomeCompleto.Sobrenome;
                lblIdCliente.Text = _vendaModel.Cliente.IdCliente.ToString();
            }
        }

        private void BtnPesquisarProduto_Click(object sender, EventArgs e)
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

        private void DgvProdutoListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
        }

        private void DgvProdutoListar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            var id = SelecionarProdutoModel();
            _produtoSelecionado = ProdutoAlterarController.Buscar(id);

            AtribuirValoresDoProdutoSelecionado(_produtoSelecionado);
            CalcularPrecosProdutoSelecionado();

            nupQuantidade.Enabled = true;
            nupDesconto.Enabled = true;
        }
        
        private void DgvCarrinho_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) => SelecionarCarrinhoModel();
        
        private void AtribuirValoresDoProdutoSelecionado(ProdutoModel produto)
        {
            lblIdProduto.Text = produto.IdProduto.ToString();
            lblProdutoSelecionado.Text = produto.Nome;
            lblPrecoProduto.Text = produto.PrecoVenda.ToString();
            lblTotalLiquidoProduto.Text = (Convert.ToDecimal(produto.PrecoVenda.RetornarValor) * nupQuantidade.Value).ToString();
            lblTotalBrutoProduto.Text = (Convert.ToDecimal(produto.PrecoVenda.RetornarValor) * nupQuantidade.Value).ToString();
            lblProdutoLucroUnitario.Text = (produto.PrecoVenda.RetornarValor - produto.PrecoCusto.RetornarValor).ToString();
            nupQuantidade.Maximum = produto.QuantidadeEstoque;
        }

        private void NupQuantidade_ValueChanged(object sender, EventArgs e) => CalcularPrecosProdutoSelecionado();
        
        private void NupDesconto_KeyUp(object sender, KeyEventArgs e) => CalcularPrecosProdutoSelecionado();
        
        private void NupDesconto_ValueChanged(object sender, EventArgs e) => CalcularPrecosProdutoSelecionado();
        
        private void NupQuantidade_KeyUp(object sender, KeyEventArgs e) => CalcularPrecosProdutoSelecionado();

        private void BtnAdicionar_Click(object sender, EventArgs e)
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

            var produto = VerificarSeExisteNoCarrinho(SelecionarProdutoModel());
            if (produto != null)
            {
                var index = _vendaModel.ListaDeItens.IndexOf(produto);

                var totalLiquido = ProdutoModel.ValorTotalLiquido
            (
                _produtoSelecionado.PrecoVenda.RetornarValor,
                Convert.ToInt32(nupQuantidade.Value),
                Convert.ToInt32(nupDesconto.Value)
            );

                _vendaModel.ListaDeItens[index].Quantidade = Convert.ToInt32(nupQuantidade.Value);
                _vendaModel.ListaDeItens[index].Desconto = Convert.ToInt32(nupDesconto.Value);
                _vendaModel.ListaDeItens[index].TotalLiquido = totalLiquido;
                AtualizarCarrinho();
                AtualizarPrecosTotais();
                MessageBox.Show("O item já existia no carrinho. Os valores foram atualizados.");
                return;
            }

            AdicionarProdutoNoCarrinho();

            AtualizarCarrinho();
            AtualizarPrecosTotais();
            LimparCamposDoProduto();
        }

        private void BtnRemover(object sender, EventArgs e)
        {
            if (_vendaModel.ListaDeItens.Count() > 0)
            {
                int selecionado = Convert.ToInt32(dgvCarrinho.SelectedRows[0].Index);
                _vendaModel.ListaDeItens.RemoveAt(selecionado);
            }
            AtualizarCarrinho();
            AtualizarPrecosTotais();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (!VerificaSeCamposEstãoPreenchidos()) return;
            if (cbFormaPagamento.Text == "A prazo")
            {
                if (!_vendaModel.VerificarLimiteGastoCompraAPrazoFoiAtingido(Convert.ToInt32(lblIdCliente.Text), _vendaModel.TotalLiquido, 0))
                {
                    var valorLimiteRestante = _vendaModel.Cliente.ValorLimiteAPrazo.RetornarValor - _vendaModel.Cliente.ValorLimiteGasto.RetornarValor;
                    MessageBox.Show($"Valor Limite de compra a prazo restante foi ultrapassado: " + valorLimiteRestante.ToString("c"));
                    return;
                }
            }

            RegistrarVenda();

            MessageBox.Show("Venda Registrada");
            if (chkEnviarEmail.Checked)
            {
                int id = Convert.ToInt32(lblIdCliente.Text);
                var cliente = ClienteAlterarController.Buscar(id);
                EmailController.EnviarEmailRegistroVenda(cliente, _vendaModel);
            }
            LimparTodosOsCampos();
        }

        private bool VerificaSeCamposEstãoPreenchidos()
        {
            if (lblClienteSelecionado.Text.Equals("Selecione um cliente. . ."))
            {
                MessageBox.Show("Selecione um cliente");
                return false;
            }
            if (lblColaboradorSelecionado.Text.Equals("Selecione um colaborador. . ."))
            {
                MessageBox.Show("Selecione um colaborador");
                return false;
            }
            if (_vendaModel.ListaDeItens.Count.Equals(0))
            {
                MessageBox.Show("Selecione pelo menos 1 item ao seu carrinho");
                return false;
            }
            if (String.IsNullOrEmpty(cbFormaPagamento.Text))
            {
                MessageBox.Show("Selecione uma forma de pagamento.");
                return false;
            }
            return true;
        }

        private void LimparCamposDoProduto()
        {
            nupDesconto.Value = 0;
            nupQuantidade.Value = 1;
        }

        private void LimparTodosOsCampos()
        {
            nupDesconto.Enabled = false;
            nupQuantidade.Enabled = false;
            lblClienteSelecionado.Text = "Selecione um cliente. . .";
            lblIdCliente.Text = "";
            lblColaboradorSelecionado.Text = "Selecione um colaborador. . .";
            lblIdColaborador.Text = "";
            lblProdutoSelecionado.Text = "Selecione um produto. . .";
            lblIdProduto.Text = "";
            lblTotalDescontoProduto.Text = "R$ 00,00";
            lblTotalLiquidoProduto.Text = "R$ 00,00";
            lblTotalBrutoProduto.Text = "R$ 00,00";
            lblLucroProduto.Text = "R$ 00,00";
            lblPrecoProduto.Text = "R$ 00,00";


            _vendaModel.ListaDeItens = new List<VendaProdutoModel>();
            dgvCarrinho.DataSource = null;
            dgvProdutoListar.DataSource = null;

            lblTotalLiquido.Text = "R$ 00,00";
            lblTotalLucro.Text = "R$ 00,00";
            lblTotalDesconto.Text = "R$ 00,00";
            lblTotalBrutoVenda.Text = "R$ 00,00";
            lblPrecoTotal.Text = "R$ 00,00";

            LimparCamposDoProduto();
            AtualizarCarrinho();
        }

        public int SelecionarProdutoModel() =>
            Convert.ToInt32(dgvProdutoListar.SelectedRows[0].Cells[0].Value);

        public string SelecionarCarrinhoModel() =>
            dgvCarrinho.SelectedRows[0].Cells[7].Value.ToString();

        private void CalcularPrecosProdutoSelecionado()
        {
            lblTotalLiquidoProduto.Text = ProdutoModel.ValorTotalBrutoProduto(_produtoSelecionado.PrecoVenda.RetornarValor, Convert.ToInt32(nupQuantidade.Value)).ToString("c");

            lblTotalBrutoProduto.Text = ProdutoModel.ValorTotalLiquido(_produtoSelecionado.PrecoVenda.RetornarValor, Convert.ToInt32(nupQuantidade.Value), Convert.ToInt32(nupDesconto.Value)).ToString("c");

            lblTotalDescontoProduto.Text = ProdutoModel.ValorTotalDescontoProduto(Convert.ToInt32(nupDesconto.Value), Convert.ToInt32(nupQuantidade.Value), lblPrecoProduto.Text.RealParaDecimal()).ToString("c");


            lblLucroProduto.Text = ProdutoModel.ValorProdutoLucro
                (
                    Convert.ToDecimal(lblProdutoLucroUnitario.Text),
                    Convert.ToInt32(nupQuantidade.Value),
                    Convert.ToInt32(nupDesconto.Value),
                    lblPrecoProduto.Text.RealParaDecimal()
                ).ToString("c");
        }

        private void AtualizarCarrinho()
        {
            dgvCarrinho.DataSource = null;
            dgvCarrinho.DataSource = _vendaModel.ListaDeItens;
        }

        private void AtualizarPrecosTotais()
        {
            lblPrecoTotal.Text = _vendaModel.TotalLiquido.ValorFormatado;
            lblTotalLiquido.Text = _vendaModel.TotalLiquido.ValorFormatado;
            lblTotalLucro.Text = _vendaModel.TotalLucro.ToString("C");
            lblTotalDesconto.Text = _vendaModel.TotalDesconto.ValorFormatado;
            lblTotalBrutoVenda.Text = _vendaModel.TotalBruto.ValorFormatado;
        }

        public VendaProdutoModel VerificarSeExisteNoCarrinho(int id) =>
            (from x in _vendaModel.ListaDeItens where x.IdProduto == id select x).FirstOrDefault();

        private void btnFechar_Click(object sender, EventArgs e) => Close();

        public void RegistrarVenda()
        {
            _vendaRegistrarController = new VendaRegistrarController();
            _vendaModel.IdColaborador = Convert.ToInt32(lblIdColaborador.Text);
            _vendaModel.Cliente.IdCliente = Convert.ToInt32(lblIdCliente.Text);
            _vendaModel.FormaPagamento = cbFormaPagamento.Text;
            if (cbFormaPagamento.Text == "A prazo")
            {
                _vendaModel.Pago = false;
            }
            else _vendaModel.Pago = true;

            _vendaModel.DataVenda = DateTime.Now;

            _vendaRegistrarController.RegistrarVenda(_vendaModel);
        }

        public void AdicionarProdutoNoCarrinho()
        {
            var totalLiquido = ProdutoModel.ValorTotalLiquido
            (
                _produtoSelecionado.PrecoVenda.RetornarValor,
                Convert.ToInt32(nupQuantidade.Value),
                Convert.ToInt32(nupDesconto.Value)
            );

            _vendaModel.ListaDeItens.Add(new VendaProdutoModel()
            {
                IdProdutoGuid = Guid.NewGuid(),
                IdProduto = lblIdProduto.Text.IntOuZero(),
                Nome = lblProdutoSelecionado.Text,
                Quantidade = Convert.ToInt32(nupQuantidade.Value),
                Desconto = (int)nupDesconto.Value,
                TotalLiquido = totalLiquido,
                PrecoVenda = lblPrecoProduto.Text.RealParaDecimal(),
                TotalBruto = lblTotalLiquidoProduto.Text.RealParaDecimal(),
                Lucro = lblLucroProduto.Text.RealParaDecimal()
            });
        }
    }
}
