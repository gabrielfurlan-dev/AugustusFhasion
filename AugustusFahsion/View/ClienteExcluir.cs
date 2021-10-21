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
using AugustusFahsion.Model;


namespace AugustusFahsion.View
{
    public partial class ClienteExcluir : Form
    {
        private ClienteExcluirController _controller;
        private ClienteModel clienteModel;
        public ClienteExcluir(ClienteExcluirController clienteExcluirController)
        {
            InitializeComponent();
            _controller = clienteExcluirController;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
