using AugustusFahsion.Controller;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.View
{
    public partial class ColaboradorListar : Form
    {
        private ColaboradorListarController _controller;
        public ColaboradorListar(ColaboradorListarController colaboradorListarController)
        {
            InitializeComponent();
            _controller = colaboradorListarController;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ColaboradorListar_Load(object sender, EventArgs e)
        {
            dgvLista.DataSource = _controller.ListarColaborador();
            dgvLista.Columns["Salario"].DisplayIndex = 16;
            dgvLista.Columns["Comissao"].DisplayIndex = 17;
            dgvLista.Columns["Banco"].DisplayIndex = 18;
            dgvLista.Columns["Agencia"].DisplayIndex = 19;
            dgvLista.Columns["Conta"].DisplayIndex = 20;
            dgvLista.Columns["TipoConta"].DisplayIndex = 21;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
