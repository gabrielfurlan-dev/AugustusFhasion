using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AugustusFahsion.View.Cadastrar
{
    public partial class ColaboradorCadastrar : Form
    {
        private ColaboradorCadastrarController _controller;
        private ColaboradorModel colaboradorModel;
        public ColaboradorCadastrar(ColaboradorCadastrarController colaboradorCadastrarController)
        {
            InitializeComponent();
            _controller = colaboradorCadastrarController;
            colaboradorModel = new ColaboradorModel { };
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
                else if (mtxtCep.Text.NuloOuVazio())
                {
                    MessageBox.Show("Insira um CEP");
                }
                else if (nupSalario.Value < 0)
                {
                    MessageBox.Show("Insira um salario válido.");
                }
                else if (nupComissao.Value < 0)
                {
                    MessageBox.Show("Insira uma comissão válida.");
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
                else if (txtBanco.Text.NuloOuVazio())
                {
                    MessageBox.Show("Insira um banco");
                }
                else if (mtxtAgencia.Text.NuloOuVazio())
                {
                    MessageBox.Show("Insira o número da agência bancária.");
                }
                else if (mtxtConta.Text.NuloOuVazio())
                {
                    MessageBox.Show("Insira o numero da conta bancária");
                }
                else if (cbTipoConta.Text.NuloOuVazio())
                {
                    MessageBox.Show("Selecione o tipo da conta bancária.");
                }
                else
                {
                    colaboradorModel.Nome = txtNome.Text;
                    colaboradorModel.Sobrenome = txtSobrenome.Text;
                    colaboradorModel.Sexo = cbSexo.Text;
                    colaboradorModel.DataNascimento = Convert.ToDateTime(dtpDataNascimento.Text);
                    colaboradorModel.Salario = (double)nupSalario.Value;
                    colaboradorModel.Comissao = (int)nupComissao.Value;
                    colaboradorModel.Cep = mtxtCep.Text;
                    colaboradorModel.Logradouro = txtLogradouro.Text;
                    colaboradorModel.Cidade = txtCidade.Text;
                    colaboradorModel.Uf = cbUf.Text;
                    colaboradorModel.Complemento = txtComplemento.Text;
                    colaboradorModel.Bairro = txtBairro.Text;
                    colaboradorModel.NumeroEndereco = txtNumeroEndereco.Text;
                    colaboradorModel.Telefone = txtTelefone.Text;
                    colaboradorModel.Celular = mtxtCelular.Text;
                    colaboradorModel.Email = txtEmail.Text;
                    colaboradorModel.Cpf = mtxtCpf.Text;

                    colaboradorModel.Banco = txtBanco.Text;
                    colaboradorModel.Agencia = mtxtAgencia.Text;
                    colaboradorModel.Conta = mtxtConta.Text;
                    colaboradorModel.TipoConta = cbTipoConta.Text;

                    _controller.CadastrarColaborador(colaboradorModel);
                    this.Close();
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
