using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AugustusFahsion.View
{
    public partial class ClienteCadastrar : Form
    {
        private ClienteCadastrarController _controller;
        private ClienteModel clienteModel;
        private Validar validar;

        public ClienteCadastrar(ClienteCadastrarController clienteCadastrarController)
        {
            InitializeComponent();
            _controller = clienteCadastrarController;
            validar = new Validar { };

            clienteModel = new ClienteModel{};
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNome.Text))
                {
                    MessageBox.Show("Insira um nome.");
                }
                else if (String.IsNullOrEmpty(txtSobrenome.Text))
                {
                    MessageBox.Show("Insira um sobrenome");
                }
                else if (String.IsNullOrEmpty(cbSexo.Text))
                {
                    MessageBox.Show("Selecione o sexo.");
                }
                else if (dtpDataNascimento.Value >= DateTime.Now)
                {
                    MessageBox.Show("Selecione uma data de nascimento valida");
                }
                else if (nupValorLimiteAPrazo.Value < 0)
                {
                    MessageBox.Show("Insira um valor a prazo válido");
                }
                else if (String.IsNullOrEmpty(mtxtCep.Text))
                {
                    MessageBox.Show("Insira um CEP");
                }
                else if (String.IsNullOrEmpty(txtLogradouro.Text))
                {
                    MessageBox.Show("Insira um Logradouro");
                }
                else if (String.IsNullOrEmpty(txtCidade.Text))
                {
                    MessageBox.Show("Insira uma cidade");
                }
                else if (String.IsNullOrEmpty(cbUf.Text))
                {
                    MessageBox.Show("Selecione um Estado (UF)");
                }
                else if (String.IsNullOrEmpty(txtBairro.Text))
                {
                    MessageBox.Show("Insira um bairro");
                }
                else if (String.IsNullOrEmpty(txtNumeroEndereco.Text))
                {
                    MessageBox.Show("Insira um numero de endereço.");
                }
                else if (!new Regex("[(][0-9]{3}[)] [9][0-9]{4}[-][0-9]{3}").Match(mtxtCelular.Text).Success)
                {
                    MessageBox.Show("Insira um numero de celular válido");
                }
                else if (String.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Insira um endereço de email.");
                }
                else if (!new Regex("[0-9]{3}[.][0-9]{3}[.][0-9]{3}[-][0-9]{2}").Match(mtxtCpf.Text).Success)
                {
                    MessageBox.Show("Insira um CPF");
                }
                else
                {

                    clienteModel.Nome = txtNome.Text;
                    clienteModel.Sobrenome = txtSobrenome.Text;
                    clienteModel.Sexo = cbSexo.Text;
                    clienteModel.DataNascimento = Convert.ToDateTime(dtpDataNascimento.Text);
                    clienteModel.ValorLimiteAPrazo = (double)nupValorLimiteAPrazo.Value;
                    clienteModel.Cep = mtxtCep.Text;
                    clienteModel.Logradouro = txtLogradouro.Text;
                    clienteModel.Cidade = txtCidade.Text;
                    clienteModel.Uf = cbUf.Text;
                    clienteModel.Complemento = txtComplemento.Text;
                    clienteModel.Bairro = txtBairro.Text;
                    clienteModel.NumeroEndereco = txtNumeroEndereco.Text;
                    clienteModel.Telefone = txtTelefone.Text;
                    clienteModel.Celular = mtxtCelular.Text;
                    clienteModel.Email = txtEmail.Text;
                    clienteModel.Cpf = mtxtCpf.Text;

                    _controller.CadastrarCliente(clienteModel);
                    this.Close();
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
        }
    

       
    }
}
