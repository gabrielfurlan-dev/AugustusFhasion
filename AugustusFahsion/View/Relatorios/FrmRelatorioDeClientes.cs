using AugustusFahsion.Controller.Relatorios;
using System.Windows.Forms;

namespace AugustusFahsion.View.Relatorios
{
    public partial class FrmRelatorioDeClientes : Form
    {
        RelatorioDeClientesController _relatorioDeClientesController;
        public FrmRelatorioDeClientes(RelatorioDeClientesController relatorioDeClientesController)
        {
            _relatorioDeClientesController = relatorioDeClientesController;
            InitializeComponent();
        }

        private void button2_Click(object sender, System.EventArgs e) => panelFiltros.Visible = false;

        private void btnFechar_Click(object sender, System.EventArgs e) => this.Close();

        private void btnMostrarFiltros_Click(object sender, System.EventArgs e) => panelFiltros.Visible = true;
    }
}
