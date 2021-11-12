using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AugustusFahsion.Controller;
using AugustusFahsion.Controller.Venda;
using AugustusFahsion.Model;
using AugustusFahsion.Model.Venda;

namespace AugustusFahsion.View.Venda
{
    public partial class FrmVendaRegistrar : Form
    {
        VendaRegistrarController _controllerRegistrar;
        ClienteListarController _clienteListarController;
        ColaboradorListarController _colaboradorListarController;
        ProdutoListarController _produtoListarController;

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
            {
                dgvProdutoListar.DataSource = _produtoListarController.ListarProdutosAtivosPorId(int.Parse(txtProcurar.Text));
            }
            else if (txtProcurar.Text == "%")
            {
                dgvProdutoListar.DataSource = _produtoListarController.ListarProdutosAtivos();
            }
            else
            {
                dgvProdutoListar.DataSource = _produtoListarController.ListarProdutosAtivosPorNome(txtProcurar.Text);
            }
        }


        //DvgCellMouseCLick
        private void dgvProdutoListar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = SelecionarProdutoModel();
            var produto = ProdutoAlterarController.Buscar(id);
            lblProdutoSelecionado.Text = produto.Nome;
            lblPrecoProduto.Text = produto.PrecoVenda.ToString();
            lblTotalProdutoSemDesconto.Text = (Convert.ToDecimal(produto.PrecoVenda) * nupQuantidade.Value).ToString();
            lblTotalProdutoComDesconto.Text = (Convert.ToDecimal(produto.PrecoVenda) * nupQuantidade.Value).ToString();
        }
        private void dgvClienteListar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = SelecionarClienteModel();
            var cliente = ClienteAlterarController.Buscar(id);
            lblClienteSelecionado.Text = cliente.NomeCompleto.ToString();
        }
        private void dgvColaboradorListar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = SelecionarColaboradorModel();
            var colaborador = ColaboradorAlterarController.Buscar(id);
            lblColaboradorSelecionado.Text = colaborador.NomeCompleto.ToString();
        }
        private void dgvCarrinho_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) => 
            SelecionarCarrinhoModel();

        //atualizar preços
        private void nupQuantidade_ValueChanged(object sender, EventArgs e) => AtualizarPrecos();
        private void nupQuantidade_KeyPress(object sender, KeyPressEventArgs e) => AtualizarPrecos();
        private void nupQuantidade_KeyDown(object sender, KeyEventArgs e) => AtualizarPrecos();
        private void nupDesconto_ValueChanged(object sender, EventArgs e) => AtualizarPrecos();
        private void nupDesconto_KeyPress(object sender, KeyPressEventArgs e) => AtualizarPrecos();
        private void nupDesconto_KeyDown(object sender, KeyEventArgs e) => AtualizarPrecos();


        //funções do carinhho
        List<CarrinhoModel> CarrinhoLista = new List<CarrinhoModel>();
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (lblProdutoSelecionado.Text.Equals("Selecione um produto. . ."))
                MessageBox.Show("Selecione um produto primeiro.");

            else if (nupQuantidade.Value < 1)
                MessageBox.Show("Informe a quantidade");
            else {
                var desconto = TotalDesconto();
                    
                CarrinhoLista.Add(new CarrinhoModel() {
                    NomeProduto = lblProdutoSelecionado.Text, 
                    Desconto = (int)nupDesconto.Value, 
                    PrecoLiquido = desconto,
                    PrecoVenda = Convert.ToDecimal(lblPrecoProduto.Text),
                    Quantidade = Convert.ToInt32(nupQuantidade.Value),
                    total = Convert.ToDecimal(lblTotalProdutoSemDesconto.Text)
                });

                dgvCarrinho.DataSource = null;
                dgvCarrinho.DataSource = CarrinhoLista;
            }
        }
        private void btnRemover(object sender, EventArgs e)
        {
            var item = SelecionarCarrinhoModel();
            CarrinhoLista.RemoveAt(item);
        }


        //=====================================================================================
        //selecionar Model
        public int SelecionarClienteModel() => Convert.ToInt32(dgvClienteListar.SelectedRows[0].Cells[0].Value);
        public int SelecionarColaboradorModel() => Convert.ToInt32(dgvColaboradorListar.SelectedRows[0].Cells[0].Value);
        public int SelecionarProdutoModel() => Convert.ToInt32(dgvProdutoListar.SelectedRows[0].Cells[0].Value);
        public int SelecionarCarrinhoModel() => dgvCarrinho.Rows.GetRowCount(DataGridViewElementStates.Selected);

        //Metodos atualizar precos
        private decimal ValorTotalProdutoSemDesconto() => 
            Convert.ToDecimal(lblPrecoProduto.Text) * Convert.ToDecimal(nupQuantidade.Value);
        private decimal ValorTotalProdutoComDesconto() => 
            ValorTotalProdutoSemDesconto() - TotalDesconto();
        private decimal TotalDesconto() => 
            ValorTotalProdutoSemDesconto() - (ValorTotalProdutoSemDesconto() * 
            (Convert.ToDecimal(nupDesconto.Value) * Convert.ToDecimal(0.01)));
        private void AtualizarPrecos()
        {
            lblTotalProdutoSemDesconto.Text = ValorTotalProdutoSemDesconto().ToString();
            lblTotalProdutoComDesconto.Text = TotalDesconto().ToString();
            lblTotalDeDesconto.Text = ValorTotalProdutoComDesconto().ToString();

        }

    }
}
