using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.View.Excluir
{
    

    public partial class ColaboradorExcluir : Form
    {
        private ColaboradorExcluirController _controller;
        private ColaboradorModel colaboradorModel;
        public ColaboradorExcluir(ColaboradorExcluirController colaboradorExcluirController)
        {
            InitializeComponent();
            _controller = colaboradorExcluirController;

            colaboradorModel = new ColaboradorModel();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                Int32.TryParse(txtId.Text, out id);

                var validaID = new ColaboradorExcluirController().ValidarId(id);
                if (id > 0 && validaID)
                {
                    colaboradorModel.IdPessoa = int.Parse(txtId.Text);
                    _controller.ExcluirColaborador(colaboradorModel);
                    MessageBox.Show("Colaborador excluido com sucesso");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("id invalido!");
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
