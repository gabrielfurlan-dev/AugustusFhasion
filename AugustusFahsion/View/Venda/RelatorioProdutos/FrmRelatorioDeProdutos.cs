using AugustusFahsion.Controller.Venda;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.View.Venda
{
    public partial class FrmRelatorioDeProdutos : Form
    {
        private RelatorioDeProdutosController _relatorioDeVendasController;
        public FrmRelatorioDeProdutos(RelatorioDeProdutosController relatorioDeVendasController)
        {
            InitializeComponent();
            _relatorioDeVendasController = relatorioDeVendasController;
        }

        private void BtnFechar_Click(object sender, EventArgs e) => this.Close();
        private void BtnAbrirFiltros_Click(object sender, EventArgs e) => panelFiltros.Visible = true;
        private void BtnFecharFiltros_Click(object sender, EventArgs e) => panelFiltros.Visible = false;
        private void FrmRelatorioDeVendas_Load(object sender, EventArgs e) => panelFiltros.Visible = false;

        private void btnFiltrarPorProduto_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            dgvListaVenda.DataSource = _relatorioDeVendasController.FiltrarPorCliente(txtFiltrarPorCliente.Text);
        }
    }
}
