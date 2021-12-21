using AugustusFahsion.Controller.Venda;
using AugustusFahsion.Model;
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
        private int _idCliente;
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
            _filtros.IdCliente = _idCliente;
            _filtros.NomeProduto = txtNomeProduto.Text;
            _filtros.DataInicial = dtDataInicial.Value;
            _filtros.DataFinal = dtDataFinal.Value;
        }

        private void btnFiltrarPorProduto_Click(object sender, EventArgs e)
        {
            if(ValidarCampos())
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
        }

        private bool ValidarCampos()
        {
            if (dtDataInicial.Value > dtDataFinal.Value) 
            {
                MessageBox.Show("A data Inicial não pode ser menor que a data final.");
                return false;
            }
            return true;
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

        private void btnProcurarCliente_Click(object sender, EventArgs e)
        {
            var cliente = new VendaRegistrarController().ProcurarCliente();

            if (cliente != null)
            {
                _idCliente = cliente.IdCliente;
                txtCliente.Text = cliente.NomeCompleto.Nome + " " + cliente.NomeCompleto.Sobrenome;
            }
        }

        private void dgvListaVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
