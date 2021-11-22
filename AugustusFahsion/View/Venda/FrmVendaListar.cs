using AugustusFahsion.Controller.Venda;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.View.Venda
{
    public partial class FrmVendaListar : Form
    {
        VendaListarController _vendaListagemcontroller = new VendaListarController();
        VendaAlterarController _alterarVendaController = new VendaAlterarController();
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
        private void btnProcurar_Click(object sender, EventArgs e) => dgvListaVenda.DataSource = _vendaListagemcontroller.ListarVendas();

        private void dgvListaVenda_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                
        }

        private int SelecionarVendaModel() => Convert.ToInt32(dgvListaVenda.SelectedRows[0].Cells[0].Value);

        private void dgvListaVenda_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = SelecionarVendaModel();
            var venda = _alterarVendaController.BuscarVenda(id);
            _alterarVendaController.AbrirFormulario(venda);
        }
    }
}
