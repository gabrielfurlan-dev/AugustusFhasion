using AugustusFahsion.Controller.Venda;
using AugustusFahsion.Model;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.View.Venda
{
    public partial class FrmVendaAlterar : Form
    {
        private VendaAlterarController _controllerAlterar;
        private VendaExcluirController _controllerExcluir;
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
        }

        public void AtribuirModelParaCampos(VendaModel vendaModelSelecionada)
        {

            var id = vendaModelSelecionada.IdVenda;
            var vendaModel = _controllerAlterar.BuscarVenda(id);
            var vendaListagemModel = new VendaListarController().ListarVendaSelecionada(id);

            lblIdVenda.Text = vendaModel.IdVenda.ToString();
            lblClienteSelecionado.Text = vendaListagemModel[0].NomeCliente;
            lblColaboradorSelecionado.Text = vendaListagemModel[0].NomeColaborador;

 
        }

        public VendaModel SelecionarVendaModel(int id) => _controllerAlterar.BuscarVenda(id);
        

        private void btnExcluirVenda_Click(object sender, EventArgs e)
        {
            //_controllerExcluir.ExcluirVenda(vendaModel);
        }

        private void dgvProdutosVenda_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //var id = SelecionarVendaModel();
            //var venda = _controllerAlterar.BuscarVenda(id);

            //lblIdProduto.Text = produto.IdProduto.ToString();
            //lblProdutoSelecionado.Text = produto.Nome;
            //lblPrecoProduto.Text = produto.PrecoVenda.ToString();
            //lblTotalProdutoSemDesconto.Text = (Convert.ToDecimal(produto.PrecoVenda) * nupQuantidade.Value).ToString();
            //lblTotalProdutoComDesconto.Text = (Convert.ToDecimal(produto.PrecoVenda) * nupQuantidade.Value).ToString();
            //AtualizarPrecosProdutoSelecionado();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
