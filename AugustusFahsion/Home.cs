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

namespace AugustusFahsion
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new ClienteCadastrarController().AbrirFormulario();
        }

        private void colaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ColaboradorCadastrarController().AbrirFormulario();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ClienteListarController().AbrirLista();
        }

        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new ClienteAlterarController().AbrirFormulario();
        }
    }
}
