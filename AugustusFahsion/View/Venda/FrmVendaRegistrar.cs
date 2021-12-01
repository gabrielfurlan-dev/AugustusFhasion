using AugustusFahsion.Controller;
using AugustusFahsion.Controller.Venda;
using AugustusFahsion.Model;
using AugustusFahsion.Model.Venda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text;
using AugustusFahsion.Controller.Email;

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
            if (e.RowIndex == -1)
                return;
            var id = SelecionarProdutoModel();
            var produto = ProdutoAlterarController.Buscar(id);
            AtribuirValoresDoProdutoSelecionado(produto);
            CalcularPrecosProdutoSelecionado();
            nupQuantidade.Enabled = true;
            nupDesconto.Enabled = true;
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
            }

            AdicionarProdutoNoCarrinho();
            AtualizarCarrinho();
            AtualizarPrecosTotais();
            LimparCamposDoProduto();
        }
        private void BtnRemover(object sender, EventArgs e)
        {
            if(_vendaModel.ListaDeItens.Count() > 0)
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

            RegistrarVenda();
            MessageBox.Show("Venda Registrada");
            if (chkEnviarEmail.Checked) 
            {
                var id = SelecionarClienteModel();
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
            nupQuantidade.Value = 0;
            lblTotalDescontoProduto.Text = "R$ 00,00";
            lblTotalLiquidoProduto.Text = "R$ 00,00";
            lblTotalBrutoProduto.Text = "R$ 00,00";
            lblLucroProduto.Text = "R$ 00,00";
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

            LimparCamposDoProduto();
            AtualizarCarrinho();

            _vendaModel.ListaDeItens = new List<VendaProdutoModel>();
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
        private decimal ValorProdutoLucro()
        {
           return (Convert.ToDecimal(lblProdutoLucroUnitario.Text) * nupQuantidade.Value) -
            (VendaAlterarController.ValorTotalDescontoProduto(Convert.ToInt32(nupDesconto.Value),
                Convert.ToInt32(nupQuantidade.Value), Extensoes.RealParaDecimal(lblPrecoProduto.Text)));
        }
        private decimal ValorTotalDesconto() {
            var valorTotalBrutoProduto = VendaAlterarController.ValorTotalBrutoProduto(Extensoes.RealParaDecimal(lblPrecoProduto.Text), Convert.ToInt32(nupQuantidade.Value));
            return valorTotalBrutoProduto - (valorTotalBrutoProduto * (Convert.ToDecimal(nupDesconto.Value) * Convert.ToDecimal(0.01)));
        } 
        private void CalcularPrecosProdutoSelecionado()
        {
            lblTotalLiquidoProduto.Text = VendaAlterarController.ValorTotalBrutoProduto(Extensoes.RealParaDecimal(lblPrecoProduto.Text), Convert.ToInt32(nupQuantidade.Value)).ToString("c");
            lblTotalBrutoProduto.Text = ValorTotalDesconto().ToString("c");
            lblTotalDescontoProduto.Text = VendaAlterarController.ValorTotalDescontoProduto(Convert.ToInt32(nupDesconto.Value), Convert.ToInt32(nupQuantidade.Value), Extensoes.RealParaDecimal(lblPrecoProduto.Text)).ToString("c");
            lblLucroProduto.Text = ValorProdutoLucro().ToString("c");
        }


        private void AtualizarCarrinho()
        {
            dgvCarrinho.DataSource = null;
            dgvCarrinho.DataSource = _vendaModel.ListaDeItens;
        }
        private void AtualizarPrecosTotais() {
            lblTotalBrutoVenda.Text = _vendaModel.TotalBruto.ValorFormatado;
            lblTotalLiquido.Text = _vendaModel.TotalLiquido.ValorFormatado;
            lblPrecoTotal.Text = _vendaModel.TotalLiquido.ValorFormatado;
            lblTotalDesconto.Text = _vendaModel.TotalDesconto.ValorFormatado;
            lblTotalLucro.Text = _vendaModel.TotalLucro.ToString("C");
        }

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
        public void RegistrarVenda() 
        {
            _vendaRegistrarController = new VendaRegistrarController();
            _vendaModel.IdColaborador = Convert.ToInt32(lblIdColaborador.Text);
            _vendaModel.Cliente.IdCliente = Convert.ToInt32(lblIdCliente.Text);
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
                Total = lblTotalLiquidoProduto.Text.RealParaDecimal(),
                //Lucro = lblLucroProduto.Text.RealParaDecimal()
            });
        }

        public VendaProdutoModel VerificarSeExisteNoCarrinho(int id) => 
            (from x in _vendaModel.ListaDeItens where x.IdProduto == id select x).FirstOrDefault();

        private void btnFechar_Click_1(object sender, EventArgs e) => this.Close();

        private void dgvProdutoListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
        }
    }
}
