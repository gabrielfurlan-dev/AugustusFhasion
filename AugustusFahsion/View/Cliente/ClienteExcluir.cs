using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using System;
using System.Windows.Forms;


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

            clienteModel = new ClienteModel();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                Int32.TryParse(txtId.Text, out id);

                var validaID = new ClienteExcluirController().ValidarId(id);
                if (id > 0 && validaID)
                {
                    clienteModel.Id = int.Parse(txtId.Text);
                    _controller.ExcluirCliente(clienteModel);
                    MessageBox.Show("Cliente excluido com sucesso");
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
    }
}
