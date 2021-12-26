using AugustusFahsion.Controller.Relatorios;
using AugustusFahsion.Controller.Venda;
using AugustusFahsion.Enums;
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
        private int _idCliente;

        public FrmRelatorioDeClientes(RelatorioDeClientesController relatorioDeClientesController)
        {
            _relatorioDeClientesController = relatorioDeClientesController;
            _filtros = new FiltrosRelatorioClientes();
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e) => panelFiltros.Visible = false;

        private void BtnFechar_Click(object sender, EventArgs e) => Close();

        private void BtnMostrarFiltros_Click(object sender, EventArgs e) => panelFiltros.Visible = true;

        private void BtnFiltrarPorCliente_Click(object sender, EventArgs e)
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
            _filtros.IdCliente = _idCliente;
            _filtros.FiltrarPor = (EFiltroRelatorioDeVenda)cbFiltrarPor.SelectedIndex;
            _filtros.QuantidadeDeClientes = (int)nupQuantidadeClientes.Value;
            _filtros.OrdenarPor = (EOrdemRelatorioDeVenda)cbOrdenarPor.SelectedIndex;
            _filtros.DirecaoOrdem = cbDirecaoOrdem.Text;
            _filtros.DataInicial = dtDataInicial.Value;
            _filtros.DataFinal = dtDataFinal.Value;
            _filtros.APartirDe = nupAPartirDe.Value;
        }

        public void AtualizarTotais(List<RelatorioClientes> resultado) 
        {
            lblTotalVendas.Text = resultado.Sum(x => (x.QuantidadeVenda)).ToString();
            lblTotalBruto.Text = resultado.Sum(x => (x.TotalBruto.RetornarValor)).ToString("c");
            lblTotalLiquido.Text = resultado.Sum(x => (x.TotalLiquido.RetornarValor)).ToString("c");
            lblTotalDesconto.Text = resultado.Sum(x => (x.Desconto.RetornarValor)).ToString("c");
            lblTotalDesconto.Text = resultado.Count(x => (x.Desconto.RetornarValor != 0)).ToString();
        }

        private void CbOrdenarPor_SelectedIndexChanged(object sender, EventArgs e) => cbDirecaoOrdem.Enabled = true;

        private void btnProcurarCliente_Click(object sender, EventArgs e)
        {
            var cliente = new VendaRegistrarController().ProcurarCliente();

            if (cliente != null)
            {
                txtNomeCliente.Text = cliente.NomeCompleto.Nome + " " + cliente.NomeCompleto.Sobrenome;
                _idCliente = cliente.IdCliente;
            }
        }
    }
}