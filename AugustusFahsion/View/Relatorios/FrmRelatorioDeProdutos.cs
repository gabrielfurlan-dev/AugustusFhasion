using AugustusFahsion.Controller.Venda;
using AugustusFahsion.Model.Relatorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AugustusFahsion.View.Venda
{
    public partial class FrmRelatorioDeProdutos : Form
    {
        private RelatorioDeProdutosController _relatorioDeVendasController;
        private FiltrosRelatorioProdutos _filtros;
        public FrmRelatorioDeProdutos(RelatorioDeProdutosController relatorioDeVendasController)
        {
            InitializeComponent();
            _relatorioDeVendasController = relatorioDeVendasController;
            _filtros = new FiltrosRelatorioProdutos();
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

        private void btnFiltrarPorProduto_Click(object sender, EventArgs e)
        {
            PreencherFiltros();
            try
            {
                var resultado = _relatorioDeVendasController.FiltrarRelatorioProdutos(_filtros);
                    dgvListaVenda.DataSource = resultado;
                    AtualizarTotais(resultado);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarTotais(List<RelatorioProdutos> resultado)
        {
            lblProdutosVendidos.Text = resultado.Sum(x => x.QuantidadeVendida).ToString();
            lblPrecoLiquido.Text = resultado.Sum(x => x.TotalPrecoLiquido.RetornarValor).ToString("c");
            lblPrecoBruto.Text = resultado.Sum(x => x.TotalBruto.RetornarValor).ToString("c");
            lblLucro.Text = resultado.Sum(x => x.TotalLucroReais.RetornarValor).ToString("c");
            lblDescontos.Text = resultado.Sum(x => x.TotalDesconto.RetornarValor).ToString("c");
            lblCusto.Text = resultado.Sum(x => x.TotalCusto.RetornarValor).ToString("c");
        }

        private void btnMostrarFiltros_Click(object sender, EventArgs e) => panelFiltros.Visible = true;

    }
}
