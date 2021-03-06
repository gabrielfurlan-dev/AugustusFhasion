using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AugustusFahsion.View.Cadastrar
{
    public partial class FrmColaboradorCadastrar : Form
    {
        private ColaboradorCadastrarController _controller;
        private ColaboradorModel colaboradorModel;
        public FrmColaboradorCadastrar(ColaboradorCadastrarController colaboradorCadastrarController)
        {
            InitializeComponent();
            _controller = colaboradorCadastrarController;
            colaboradorModel = new ColaboradorModel { };
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                PreencherCamposModel();

                _controller.CadastrarColaborador(colaboradorModel);
                this.Close();
            }
        }

        private void PreencherCamposModel()
        {
            colaboradorModel.NomeCompleto.Nome = txtNome.Text;
            colaboradorModel.NomeCompleto.Sobrenome = txtSobrenome.Text;
            colaboradorModel.Sexo = cbSexo.Text;
            colaboradorModel.DataNascimento = Convert.ToDateTime(dtpDataNascimento.Text);
            colaboradorModel.Salario = nupSalario.Value;
            colaboradorModel.Comissao = (int)nupComissao.Value;
            colaboradorModel.Endereco.Cep = mtxtCep.Text;
            colaboradorModel.Endereco.Logradouro = txtLogradouro.Text;
            colaboradorModel.Endereco.Cidade = txtCidade.Text;
            colaboradorModel.Endereco.Uf = cbUf.Text;
            colaboradorModel.Endereco.Complemento = txtComplemento.Text;
            colaboradorModel.Endereco.Bairro = txtBairro.Text;
            colaboradorModel.Endereco.NumeroEndereco = txtNumeroEndereco.Text;
            colaboradorModel.Contato.Telefone = txtTelefone.Text;
            colaboradorModel.Contato.Celular = mtxtCelular.Text;
            colaboradorModel.Contato.Email = txtEmail.Text;
            colaboradorModel.Cpf = mtxtCpf.Text;

            colaboradorModel.ContaBancaria.Banco = txtBanco.Text;
            colaboradorModel.ContaBancaria.Agencia = mtxtAgencia.Text;
            colaboradorModel.ContaBancaria.Conta = mtxtConta.Text;
            colaboradorModel.ContaBancaria.TipoConta = cbTipoConta.Text;
        }

        private bool ValidarCampos()
        {
            if (txtNome.Text.NuloOuVazio())
            {
                MessageBox.Show("Insira um nome.");
                return false;
            }
            if (txtNome.Text.NuloOuVazio())
            {
                MessageBox.Show("Insira um nome.");
                return false;
            }
            if (txtSobrenome.Text.NuloOuVazio())
            {
                MessageBox.Show("Insira um sobrenome");
                return false;
            }
            if (cbSexo.Text.NuloOuVazio())
            {
                MessageBox.Show("Selecione o sexo.");
                return false;
            }
            if (dtpDataNascimento.Value.DataDeHoje())
            {
                MessageBox.Show("Selecione uma data de nascimento valida");
                return false;
            }
            if (mtxtCep.Text.NuloOuVazio())
            {
                MessageBox.Show("Insira um CEP");
                return false;
            }
            if (nupSalario.Value < 0)
            {
                MessageBox.Show("Insira um salario válido.");
                return false;
            }
            if (nupComissao.Value < 0)
            {
                MessageBox.Show("Insira uma comissão válida.");
                return false;
            }
            if (txtLogradouro.Text.NuloOuVazio())
            {
                MessageBox.Show("Insira um Logradouro");
                return false;
            }
            if (txtCidade.Text.NuloOuVazio())
            {
                MessageBox.Show("Insira uma cidade");
                return false;
            }
            if (cbUf.Text.NuloOuVazio())
            {
                MessageBox.Show("Selecione um Estado (UF)");
                return false;
            }
            if (txtBairro.Text.NuloOuVazio())
            {
                MessageBox.Show("Insira um bairro");
                return false;
            }
            if (txtNumeroEndereco.Text.NuloOuVazio())
            {
                MessageBox.Show("Insira um numero de endereço.");
                return false;
            }
            if (!Regex.IsMatch(mtxtCelular.Text, @"[(][0-9]{2}[)] [9][0-9]{4}[-][0-9]{4}"))
            {
                MessageBox.Show("Insira um numero de celular válido");
                return false;
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Insira um endereço de email válido.");
                return false;
            }
            if (!Regex.IsMatch(mtxtCpf.Text, "[0-9]{3}[.][0-9]{3}[.][0-9]{3}[-][0-9]{2}"))
            {
                MessageBox.Show("Insira um CPF");
                return false;
            }
            if (txtBanco.Text.NuloOuVazio())
            {
                MessageBox.Show("Insira um banco");
                return false;
            }
            if (mtxtAgencia.Text.NuloOuVazio())
            {
                MessageBox.Show("Insira o número da agência bancária.");
                return false;
            }
            if (mtxtConta.Text.NuloOuVazio())
            {
                MessageBox.Show("Insira o numero da conta bancária");
                return false;
            }
            if (cbTipoConta.Text.NuloOuVazio())
            {
                MessageBox.Show("Selecione o tipo da conta bancária.");
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();

        private void btnFechar_Click(object sender, EventArgs e) => this.Close();
    }
}
