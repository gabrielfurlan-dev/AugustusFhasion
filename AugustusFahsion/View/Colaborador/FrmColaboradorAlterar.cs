using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AugustusFahsion.View.Alterar
{
    public partial class FrmColaboradorAlterar : Form
    {
        private ColaboradorAlterarController _controller;
        private ColaboradorExcluirController _controllerExcluir;
        private ColaboradorModel colaboradorModel;


        public FrmColaboradorAlterar(ColaboradorAlterarController colaboradorAlterarController)
        {
            InitializeComponent();

            _controller = colaboradorAlterarController;
            colaboradorModel = new ColaboradorModel { };
        }

        public FrmColaboradorAlterar(
            ColaboradorAlterarController colaboradorAlterarController,
            ColaboradorModel colaboradorModelSelecionado,
            ColaboradorExcluirController colaboradorExcluirController
            )
        {
            InitializeComponent();

            _controller = colaboradorAlterarController;
            colaboradorModel = colaboradorModelSelecionado;

            AtribuirModelParaCampos(colaboradorModelSelecionado);
            btnSalvar.Enabled = true;

            _controllerExcluir = colaboradorExcluirController;
        }

        private void AtribuirModelParaCampos(ColaboradorModel colaboradorModel)
        {
            txtId.Text = colaboradorModel.IdColaborador.ToString();
            txtNome.Text = colaboradorModel.NomeCompleto.Nome;
            txtSobrenome.Text = colaboradorModel.NomeCompleto.Sobrenome;
            dtpDataNascimento.Text = colaboradorModel.DataNascimento.ToString();
            cbSexo.Text = colaboradorModel.Sexo;
            mtxtCep.Text = colaboradorModel.Endereco.Cep.ToString();
            nupSalario.Value = colaboradorModel.Salario.RetornarValor;
            nupComissao.Value = colaboradorModel.Comissao;
            txtLogradouro.Text = colaboradorModel.Endereco.Logradouro;
            txtCidade.Text = colaboradorModel.Endereco.Cidade;
            cbUf.Text = colaboradorModel.Endereco.Uf;
            txtComplemento.Text = colaboradorModel.Endereco.Complemento;
            txtBairro.Text = colaboradorModel.Endereco.Bairro;
            txtNumeroEndereco.Text = colaboradorModel.Endereco.NumeroEndereco.ToString();
            txtTelefone.Text = colaboradorModel.Contato.Telefone.ToString();
            mtxtCelular.Text = colaboradorModel.Contato.Celular.ToString();
            txtEmail.Text = colaboradorModel.Contato.Email;
            mtxtCpf.Text = colaboradorModel.Cpf.RetornarValor;
            cbCondicao.Text = colaboradorModel.Condicao;

            txtBanco.Text = colaboradorModel.ContaBancaria.Banco;
            mtxtAgencia.Text = colaboradorModel.ContaBancaria.Agencia;
            cbTipoConta.Text = colaboradorModel.ContaBancaria.TipoConta;
            mtxtConta.Text = colaboradorModel.ContaBancaria.Conta;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (ValidarCampos())
            {
                PrencherCamposModel();

                _controller.AtualizarColaborador(colaboradorModel);
                this.Close();
            }
        }

        private void PrencherCamposModel()
        {
            colaboradorModel.IdColaborador = Convert.ToInt32(txtId.Text);
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
            colaboradorModel.Condicao = cbCondicao.Text;

            colaboradorModel.ContaBancaria.Banco = txtBanco.Text;
            colaboradorModel.ContaBancaria.Agencia = mtxtAgencia.Text;
            colaboradorModel.ContaBancaria.Conta = mtxtConta.Text;
            colaboradorModel.ContaBancaria.TipoConta = cbTipoConta.Text;
        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Insira um nome.");
                return false;
            }
            if (String.IsNullOrEmpty(txtSobrenome.Text))
            {
                MessageBox.Show("Insira um sobrenome");
                return false;
            }
            if (String.IsNullOrEmpty(cbSexo.Text))
            {
                MessageBox.Show("Selecione o sexo.");
                return false;
            }
            if (dtpDataNascimento.Value >= DateTime.Now)
            {
                MessageBox.Show("Selecione uma data de nascimento valida");
                return false;
            }
            if (nupSalario.Value <= 0)
            {
                MessageBox.Show("Insira um salario válido.");
                return false;
            }
            if (nupComissao.Value < 0)
            {
                MessageBox.Show("O colaborador tem comissão negativa ? kkkkk.\nInsira um valor de comissão válido.");
                return false;
            }
            if (String.IsNullOrEmpty(mtxtCep.Text))
            {
                MessageBox.Show("Insira um CEP");
                return false;
            }
            if (String.IsNullOrEmpty(txtLogradouro.Text))
            {
                MessageBox.Show("Insira um Logradouro");
                return false;
            }
            if (String.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("Insira uma cidade");
                return false;
            }
            if (String.IsNullOrEmpty(cbUf.Text))
            {
                MessageBox.Show("Selecione um Estado (UF)");
                return false;
            }
            if (String.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show("Insira um bairro");
                return false;
            }
            if (String.IsNullOrEmpty(txtNumeroEndereco.Text))
            {
                MessageBox.Show("Insira um numero de endereço.");
                return false;
            }
            if (!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Insira um endereço de email válido.");
                return false;
            }
            if (!Regex.IsMatch(mtxtCpf.Text, @"[0-9]{3}[.][0-9]{3}[.][0-9]{3}[-][0-9]{2}"))
            {
                MessageBox.Show("Insira um CPF válido");
                return false;
            }
            if (!Regex.IsMatch(mtxtCelular.Text, @"[(][0-9]{2}[)] [9][0-9]{4}[-][0-9]{4}"))
            {
                MessageBox.Show("Insira um numero de celular válido");
                return false;
            }
            if (String.IsNullOrEmpty(txtBanco.Text))
            {
                MessageBox.Show("Insira um banco");
                return false;
            }
            if (String.IsNullOrEmpty(mtxtAgencia.Text))
            {
                MessageBox.Show("Insira o número da agência bancária.");
                return false;
            }
            if (String.IsNullOrEmpty(mtxtConta.Text))
            {
                MessageBox.Show("Insira o numero da conta bancária");
                return false;
            }
            if (String.IsNullOrEmpty(cbTipoConta.Text))
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
