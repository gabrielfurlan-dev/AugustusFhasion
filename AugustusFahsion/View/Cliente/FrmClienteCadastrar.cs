using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AugustusFahsion.View
{
    public partial class FrmClienteCadastrar : Form
    {
        private ClienteCadastrarController _controller;
        private ClienteModel clienteModel;


        public FrmClienteCadastrar(ClienteCadastrarController clienteCadastrarController)
        {
            InitializeComponent();
            _controller = clienteCadastrarController;
            clienteModel = new ClienteModel{};
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text.NuloOuVazio())
                    MessageBox.Show("Insira um nome.");

                else if (txtNome.Text.NuloOuVazio())
                {
                    MessageBox.Show("Insira um nome.");
                }
                else if (txtSobrenome.Text.NuloOuVazio())
                {
                    MessageBox.Show("Insira um sobrenome");
                }
                else if (cbSexo.Text.NuloOuVazio())
                {
                    MessageBox.Show("Selecione o sexo.");
                }
                else if (dtpDataNascimento.Value.DataDeHoje())
                {
                    MessageBox.Show("Selecione uma data de nascimento valida");
                }
                else if (nupValorLimiteAPrazo.Value < 0)
                {
                    MessageBox.Show("Insira um valor a prazo válido");
                }
                else if (mtxtCep.Text.NuloOuVazio())
                {
                    MessageBox.Show("Insira um CEP");
                }
                else if (txtLogradouro.Text.NuloOuVazio())
                {
                    MessageBox.Show("Insira um Logradouro");
                }
                else if (txtCidade.Text.NuloOuVazio())
                {
                    MessageBox.Show("Insira uma cidade");
                }
                else if (cbUf.Text.NuloOuVazio())
                {
                    MessageBox.Show("Selecione um Estado (UF)");
                }
                else if (txtBairro.Text.NuloOuVazio())
                {
                    MessageBox.Show("Insira um bairro");
                }
                else if (txtNumeroEndereco.Text.NuloOuVazio())
                {
                    MessageBox.Show("Insira um numero de endereço.");
                }
                else if (!Regex.IsMatch(mtxtCelular.Text, @"[(][0-9]{3}[)] [9][0-9]{4}[-][0-9]{4}"))
                {
                    MessageBox.Show("Insira um numero de celular válido");
                }
                else if (txtEmail.Text.NuloOuVazio())
                {
                    MessageBox.Show("Insira um endereço de email.");
                }
                else if (!Regex.IsMatch(mtxtCpf.Text, "[0-9]{3}[.][0-9]{3}[.][0-9]{3}[-][0-9]{2}"))
                {
                    MessageBox.Show("Insira um CPF");
                }
                else
                {
                    clienteModel.NomeCompleto.Nome = txtNome.Text;
                    clienteModel.NomeCompleto.Sobrenome = txtSobrenome.Text;
                    clienteModel.Sexo = cbSexo.Text;
                    clienteModel.DataNascimento = Convert.ToDateTime(dtpDataNascimento.Text);
                    clienteModel.ValorLimiteAPrazo = (double)nupValorLimiteAPrazo.Value;
                    clienteModel.Endereco.Cep = mtxtCep.Text;
                    clienteModel.Endereco.Logradouro = txtLogradouro.Text;
                    clienteModel.Endereco.Cidade = txtCidade.Text;
                    clienteModel.Endereco.Uf = cbUf.Text;
                    clienteModel.Endereco.Complemento = txtComplemento.Text;
                    clienteModel.Endereco.Bairro = txtBairro.Text;
                    clienteModel.Endereco.NumeroEndereco = txtNumeroEndereco.Text;
                    clienteModel.Contato.Telefone = txtTelefone.Text;
                    clienteModel.Contato.Celular = mtxtCelular.Text;
                    clienteModel.Contato.Email = txtEmail.Text;
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
