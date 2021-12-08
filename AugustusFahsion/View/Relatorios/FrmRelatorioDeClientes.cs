using AugustusFahsion.Controller.Relatorios;
using AugustusFahsion.Model.Relatorio;
using System;
using System.Collections.Generic;
using System.Linq;
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
            if (ValidarCampos())
            {
                PreencherFiltros();
                try
                {
                    var resultado = _relatorioDeClientesController.FiltrarRelatorioClientes(_filtros);
                    dgvListaRelatorioClientes.DataSource = resultado;
                    AtualizarTotais(resultado);
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool ValidarCampos()
        {
            if (dtDataInicial.Value > dtDataFinal.Value) 
            {
                MessageBox.Show("A data inicial não pode ser maior que a data final.");
                return false;
            }
            return true;
        }

        public void PreencherFiltros()
        {
            _filtros.NomeCliente = txtNomeCliente.Text;
            _filtros.OrdenarPor = cbOdenarPor.Text;
            _filtros.QuantidadeDeClientes = (int)nupQuantidadeClientes.Value;
            _filtros.DataInicial = dtDataInicial.Value;
            _filtros.DataFinal = dtDataFinal.Value;
        }

        public void AtualizarTotais(List<RelatorioClientes> resultado) 
        {
            lblTotalVendas.Text = resultado.Sum(x => (x.QuantidadeVenda)).ToString();
            lblTotalBruto.Text = resultado.Sum(x => (x.TotalBruto.RetornarValor)).ToString("c");
            lblTotalLiquido.Text = resultado.Sum(x => (x.TotalLiquido.RetornarValor)).ToString("c");
            lblTotalDesconto.Text = resultado.Sum(x => (x.Desconto.RetornarValor)).ToString("c");
        }
    }
}