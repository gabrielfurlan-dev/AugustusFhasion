using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AugustusFahsion.View
{
    public partial class FrmClienteAlterar : Form
    {
        private ClienteAlterarController _controllerAlterar;
        private ClienteModel clienteModel;

        public FrmClienteAlterar(ClienteAlterarController clienteAlterarController)
        {
            InitializeComponent();

            _controllerAlterar = clienteAlterarController;
            clienteModel = new ClienteModel { };
        }

        public FrmClienteAlterar(
            ClienteAlterarController clienteAlterarController,
            ClienteModel clienteModelSelecionado)
        {
            InitializeComponent();

            _controllerAlterar = clienteAlterarController;
            clienteModel = clienteModelSelecionado;

            AtribuirModelParaCampos(clienteModelSelecionado);
            btnSalvar.Enabled = true;
        }
        public void AtribuirModelParaCampos(ClienteModel clienteModel)
        {
            txtId.Text = clienteModel.IdCliente.ToString();
            txtNome.Text = clienteModel.NomeCompleto.Nome;
            txtSobrenome.Text = clienteModel.NomeCompleto.Sobrenome;
            dtpDataNascimento.Text = clienteModel.DataNascimento.ToString();
            cbSexo.Text = clienteModel.Sexo;
            mtxtCep.Text = clienteModel.Endereco.Cep.ToString();
            nupValorLimiteAPrazo.Value = (decimal)clienteModel.ValorLimiteAPrazo;
            txtLogradouro.Text = clienteModel.Endereco.Logradouro;
            txtCidade.Text = clienteModel.Endereco.Cidade;
            cbUf.Text = clienteModel.Endereco.Uf;
            txtComplemento.Text = clienteModel.Endereco.Complemento;
            txtBairro.Text = clienteModel.Endereco.Bairro;
            txtNumeroEndereco.Text = clienteModel.Endereco.NumeroEndereco.ToString();
            txtTelefone.Text = clienteModel.Contato.Telefone.ToString();
            mtxtCelular.Text = clienteModel.Contato.Celular.ToString();
            txtEmail.Text = clienteModel.Contato.Email;
            mtxtCpf.Text = clienteModel.Cpf.RetornarValor;
            cbCondicao.Text = clienteModel.Condicao;
        }
        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNome.Text))
                {
                    MessageBox.Show("Insira um nome.");
                    return;
                }
                if (String.IsNullOrEmpty(txtSobrenome.Text))
                {
                    MessageBox.Show("Insira um sobrenome");
                    return;
                }
                if (String.IsNullOrEmpty(cbSexo.Text))
                {
                    MessageBox.Show("Selecione o sexo.");
                    return;
                }
                if (dtpDataNascimento.Value >= DateTime.Now)
                {
                    MessageBox.Show("Selecione uma data de nascimento valida");
                    return;
                }
                if (nupValorLimiteAPrazo.Value < 0)
                {
                    MessageBox.Show("Insira um valor a prazo válido");
                    return;
                }
                if (String.IsNullOrEmpty(mtxtCep.Text))
                {
                    MessageBox.Show("Insira um CEP");
                    return;
                }
                if (String.IsNullOrEmpty(txtLogradouro.Text))
                {
                    MessageBox.Show("Insira um Logradouro");
                    return;
                }
                if (String.IsNullOrEmpty(txtCidade.Text))
                {
                    MessageBox.Show("Insira uma cidade");
                    return;
                }
                if (String.IsNullOrEmpty(cbUf.Text))
                {
                    MessageBox.Show("Selecione um Estado (UF)");
                    return;
                }
                if (String.IsNullOrEmpty(txtBairro.Text))
                {
                    MessageBox.Show("Insira um bairro");
                    return;
                }
                if (String.IsNullOrEmpty(txtNumeroEndereco.Text))
                {
                    MessageBox.Show("Insira um numero de endereço.");
                    return;
                }
                if (!new Regex("[(][0-9]{3}[)] [9][0-9]{4}[-][0-9]{3}").Match(mtxtCelular.Text).Success)
                {
                    MessageBox.Show("Insira um numero de celular válido");
                    return;
                }
                if (String.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Insira um endereço de email.");
                    return;
                }
                if (!new Regex("[0-9]{3}[.][0-9]{3}[.][0-9]{3}[-][0-9]{2}").Match(mtxtCpf.Text).Success)
                {
                    MessageBox.Show("Insira um CPF");
                    return;
                }
                
                clienteModel.IdCliente = int.Parse(txtId.Text);
                clienteModel.NomeCompleto.Nome = txtNome.Text;
                clienteModel.NomeCompleto.Sobrenome = txtSobrenome.Text;
                clienteModel.Sexo = cbSexo.Text;
                clienteModel.DataNascimento = Convert.ToDateTime(dtpDataNascimento.Text);
                clienteModel.ValorLimiteAPrazo = double.Parse(nupValorLimiteAPrazo.Text);
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
                clienteModel.Condicao = cbCondicao.Text;

                _controllerAlterar.AtualizarCliente(clienteModel);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao tentar gravar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();

        private void btnFechar_Click(object sender, EventArgs e) => this.Close();
    }
}