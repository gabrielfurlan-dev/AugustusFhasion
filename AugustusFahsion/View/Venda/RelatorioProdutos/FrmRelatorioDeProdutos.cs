using AugustusFahsion.Controller.Venda;
using AugustusFahsion.Model.Relatorio;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.View.Venda
{
    public partial class FrmRelatorioDeProdutos : Form
    {
        private RelatorioDeProdutosController _relatorioDeVendasController;
        private FiltrosRelatorioProduto _filtros;
        public FrmRelatorioDeProdutos(RelatorioDeProdutosController relatorioDeVendasController)
        {
            InitializeComponent();
            _relatorioDeVendasController = relatorioDeVendasController;
            _filtros = new FiltrosRelatorioProduto();
        }

        private void BtnFechar_Click(object sender, EventArgs e) => this.Close();
        private void BtnFecharFiltros_Click(object sender, EventArgs e) => panelFiltros.Visible = false;
        private void FrmRelatorioDeVendas_Load(object sender, EventArgs e) => panelFiltros.Visible = false;

        private void PreencherFiltros()
        {
            _filtros.IdCliente = int.TryParse(txtIdCliente.Text, out int saida) ? saida : 0;
            _filtros.NomeProduto = txtNomeProduto.Text;
            _filtros.DataInicial = dtDataInicial.Value;
            _filtros.DataFinal = dtDataFinal.Value;
        }

        private void BtnAbrirFiltros_Click(object sender, EventArgs e) => panelFiltros.Visible = true;

        private void btnFiltrarPorProduto_Click(object sender, EventArgs e)
        {
            PreencherFiltros();
            try
            {
                dgvListaVenda.DataSource = _relatorioDeVendasController.Filtrar(_filtros);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrarFiltros_Click(object sender, EventArgs e) => panelFiltros.Visible = true;
    }
}
