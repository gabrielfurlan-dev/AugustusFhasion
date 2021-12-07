using AugustusFahsion.Controller.Relatorios;
using AugustusFahsion.Model.Relatorio;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.View.Relatorios
{
    public partial class FrmRelatorioDeClientes : Form
    {
        RelatorioDeClientesController _relatorioDeClientesController;
        FiltrosRelatorioClientes _filtros;
        public FrmRelatorioDeClientes(RelatorioDeClientesController relatorioDeClientesController)
        {
            _relatorioDeClientesController = relatorioDeClientesController;
            _filtros = new FiltrosRelatorioClientes();
            InitializeComponent();
        }

        private void button2_Click(object sender, System.EventArgs e) => panelFiltros.Visible = false;

        private void btnFechar_Click(object sender, System.EventArgs e) => this.Close();

        private void btnMostrarFiltros_Click(object sender, System.EventArgs e) => panelFiltros.Visible = true;

        private void btnFiltrarPorCliente_Click(object sender, System.EventArgs e)
        {
            PreencherFiltros();
            try
            {
                dgvListaRelatorioClientes.DataSource = _relatorioDeClientesController.FiltrarRelatorioClientes(_filtros);
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void PreencherFiltros()
        {
            _filtros.NomeCliente = txtNomeCliente.Text;
            _filtros.OrdenarPor = cbOdenarPor.Text;
            _filtros.QuantidadeDeClientes = int.TryParse(nupQuantidadeClientes.Text, out int saida) ? saida : 0;
            _filtros.DataInicial = dtDataInicial.Value;
            _filtros.DataFinal = dtDataFinal.Value;
        }
    }
}
