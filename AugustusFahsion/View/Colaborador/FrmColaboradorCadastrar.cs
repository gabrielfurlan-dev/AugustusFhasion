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
            try
            {
                if (txtNome.Text.NuloOuVazio())
                {
                    MessageBox.Show("Insira um nome.");
                    return;
                }

                if (txtNome.Text.NuloOuVazio())
                {
                    MessageBox.Show("Insira um nome.");
                    return;
                }
                if (txtSobrenome.Text.NuloOuVazio())
                {
                    MessageBox.Show("Insira um sobrenome");
                    return;
                }
                if (cbSexo.Text.NuloOuVazio())
                {
                    MessageBox.Show("Selecione o sexo.");
                    return;
                }
                if (dtpDataNascimento.Value.DataDeHoje())
                {
                    MessageBox.Show("Selecione uma data de nascimento valida");
                    return;
                }
                if (mtxtCep.Text.NuloOuVazio())
                {
                    MessageBox.Show("Insira um CEP");
                    return;
                }
                if (nupSalario.Value < 0)
                {
                    MessageBox.Show("Insira um salario válido.");
                    return;
                }
                if (nupComissao.Value < 0)
                {
                    MessageBox.Show("Insira uma comissão válida.");
                    return;
                }
                if (txtLogradouro.Text.NuloOuVazio())
                {
                    MessageBox.Show("Insira um Logradouro");
                    return;
                }
                if (txtCidade.Text.NuloOuVazio())
                {
                    MessageBox.Show("Insira uma cidade");
                    return;
                }
                if (cbUf.Text.NuloOuVazio())
                {
                    MessageBox.Show("Selecione um Estado (UF)");
                    return;
                }
                if (txtBairro.Text.NuloOuVazio())
                {
                    MessageBox.Show("Insira um bairro");
                    return;
                }
                if (txtNumeroEndereco.Text.NuloOuVazio())
                {
                    MessageBox.Show("Insira um numero de endereço.");
                    return;
                }
                if (!Regex.IsMatch(mtxtCelular.Text, @"[(][0-9]{3}[)] [9][0-9]{4}[-][0-9]{4}"))
                {
                    MessageBox.Show("Insira um numero de celular válido");
                    return;
                }
                if (txtEmail.Text.NuloOuVazio())
                {
                    MessageBox.Show("Insira um endereço de email.");
                    return;
                }
                if (!Regex.IsMatch(mtxtCpf.Text, "[0-9]{3}[.][0-9]{3}[.][0-9]{3}[-][0-9]{2}"))
                {
                    MessageBox.Show("Insira um CPF");
                    return;
                }
                if (txtBanco.Text.NuloOuVazio())
                {
                    MessageBox.Show("Insira um banco");
                    return;
                }
                if (mtxtAgencia.Text.NuloOuVazio())
                {
                    MessageBox.Show("Insira o número da agência bancária.");
                    return;
                }
                if (mtxtConta.Text.NuloOuVazio())
                {
                    MessageBox.Show("Insira o numero da conta bancária");
                    return;
                }
                if (cbTipoConta.Text.NuloOuVazio())
                {
                    MessageBox.Show("Selecione o tipo da conta bancária.");
                    return;
                }
               
                colaboradorModel.NomeCompleto.Nome = txtNome.Text;
                colaboradorModel.NomeCompleto.Sobrenome = txtSobrenome.Text;
                colaboradorModel.Sexo = cbSexo.Text;
                colaboradorModel.DataNascimento = Convert.ToDateTime(dtpDataNascimento.Text);
                colaboradorModel.Salario = (double)nupSalario.Value;
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

                _controller.CadastrarColaborador(colaboradorModel);
                this.Close();
                
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
            
        }
        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();
        
    }
}
