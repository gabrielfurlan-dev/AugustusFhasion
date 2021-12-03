using AugustusFahsion.Controller.Venda;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.View.Venda
{
    public partial class FrmRelatorioDeVendas : Form
    {
        private RelatorioDeVendasController _relatorioDeVendasController;
        public FrmRelatorioDeVendas(RelatorioDeVendasController relatorioDeVendasController)
        {
            InitializeComponent();
            _relatorioDeVendasController = relatorioDeVendasController;
        }

        private void BtnFechar_Click(object sender, EventArgs e) => this.Close();
        private void BtnAbrirFiltros_Click(object sender, EventArgs e) => panelFiltros.Visible = true;
        private void BtnFecharFiltros_Click(object sender, EventArgs e) => panelFiltros.Visible = false;
    }
}
