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

        private void btnProcurar_Click(object sender, EventArgs e) => dgvListaVenda.DataSource = _vendaListagemcontroller.ListarVendas();

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
    }
}
