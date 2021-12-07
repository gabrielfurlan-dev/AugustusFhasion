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
    }
}
