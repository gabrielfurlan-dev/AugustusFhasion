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
    public partial class ColaboradorCadastrar : Form
    {
        private ColaboradorCadastrarController _controller;
        private ColaboradorModel colaboradorModel;
        public ColaboradorCadastrar(ColaboradorCadastrarController colaboradorCadastrarController)
        {
            InitializeComponent();

            _controller = colaboradorCadastrarController;

            colaboradorModel = new ColaboradorModel
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
            };

            //_controller.CadastrarColaboradors(colaboradorModel);
            //_controller.ListarCcolaboradores();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            colaboradorModel.Nome = txtNome.Text;
            colaboradorModel.Email = txtEmail.Text;
            colaboradorModel.Telefone = txtTelefone.Text;

            _controller.CadastrarColaborador(colaboradorModel);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
