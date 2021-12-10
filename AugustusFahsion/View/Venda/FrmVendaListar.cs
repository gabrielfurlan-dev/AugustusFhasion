using AugustusFahsion.Controller.Venda;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.View.Venda
{
    public partial class FrmVendaListar : Form
    {
        VendaListarController _vendaListagemcontroller = new VendaListarController();
        VendaAlterarController _alterarVendaController = new VendaAlterarController();
        private int _idVendamodelSelecionada = 0;
        public FrmVendaListar()
        {
            InitializeComponent();
        }
        public FrmVendaListar(VendaListarController vendaListarController)
        {
            InitializeComponent();
            _vendaListagemcontroller = vendaListarController;
        }
        private void btnFechar_Click(object sender, EventArgs e) => this.Close();
        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();


        private void dgvListaVenda_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _idVendamodelSelecionada = SelecionarVendaModel();
            btnAlterar.Enabled = true;
        }

        private int SelecionarVendaModel() => Convert.ToInt32(dgvListaVenda.SelectedRows[0].Cells[0].Value);

        private void dgvListaVenda_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = SelecionarVendaModel();
            var venda = VendaAlterarController.BuscarVenda(id);
            _alterarVendaController.AbrirFormulario(venda);
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var venda = VendaAlterarController.BuscarVenda(_idVendamodelSelecionada);
            _alterarVendaController.AbrirFormulario(venda);
        }

        private void btnFechar_Click_1(object sender, EventArgs e) => this.Close();

        private void btnCancelar_Click_1(object sender, EventArgs e) => this.Close();

        private void dateDataFinal_ValueChanged(object sender, EventArgs e)
        {
            FiltrarPorData();
        }


        private void dateDataInicial_ValueChanged(object sender, EventArgs e)
        {
            FiltrarPorData();
        }
        private void FiltrarPorData()
        {
            dgvListaVenda.DataSource = VendaListarController.FiltrarPorData(dateDataInicial.Value, dateDataFinal.Value);
        }

        private void btnFiltrarPorCliente_Click(object sender, EventArgs e) =>
            dgvListaVenda.DataSource = _vendaListagemcontroller.FiltrarPorCliente(txtFiltrarPorCliente.Text);

        private void btnFiltrarPorColaborador_Click(object sender, EventArgs e) =>
            dgvListaVenda.DataSource = _vendaListagemcontroller.FiltrarPorColaborador(txtFiltrarPorColaborador.Text);

        //private void btnFiltrarPorProduto_Click(object sender, EventArgs e) =>
        //    dgvListaVenda.DataSource = _vendaListagemcontroller.FiltrarPor();

    }
}
