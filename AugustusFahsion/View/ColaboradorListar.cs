using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AugustusFahsion.Controller;

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
        }
    }
}
