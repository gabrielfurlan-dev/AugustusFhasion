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
            txtId.Text = colaboradorModel.IdPessoa.ToString();
            txtNome.Text = colaboradorModel.NomeCompleto.Nome;
            txtSobrenome.Text = colaboradorModel.NomeCompleto.Sobrenome;
            dtpDataNascimento.Text = colaboradorModel.DataNascimento.ToString();
            cbSexo.Text = colaboradorModel.Sexo;
            mtxtCep.Text = colaboradorModel.Endereco.Cep.ToString();
            nupSalario.Value = (decimal)colaboradorModel.Salario;
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

            txtBanco.Text = colaboradorModel.ContaBancaria.Banco;
            mtxtAgencia.Text = colaboradorModel.ContaBancaria.Agencia;
            cbTipoConta.Text = colaboradorModel.ContaBancaria.TipoConta;
            mtxtConta.Text = colaboradorModel.ContaBancaria.Conta;
        }
        private void btnCancelar_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
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
                else if (nupSalario.Value <= 0)
                {
                    MessageBox.Show("Insira um salario válido.");
                }
                else if (nupComissao.Value < 0)
                {
                    MessageBox.Show("O colaborador tem comissão negativa ? kkkkk.\nInsira um valor de comissão válido.");
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

                else if (String.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Insira um endereço de email.");
                }
                else if (!new Regex("[0-9]{3}[.][0-9]{3}[.][0-9]{3}[-][0-9]{2}").Match(mtxtCpf.Text).Success)
                {
                    MessageBox.Show("Insira um CPF");
                }
                else if (String.IsNullOrEmpty(txtBanco.Text))
                {
                    MessageBox.Show("Insira um banco");
                }
                else if (String.IsNullOrEmpty(mtxtAgencia.Text))
                {
                    MessageBox.Show("Insira o número da agência bancária.");
                }
                else if (String.IsNullOrEmpty(mtxtConta.Text))
                {
                    MessageBox.Show("Insira o numero da conta bancária");
                }
                else if (String.IsNullOrEmpty(cbTipoConta.Text))
                {
                    MessageBox.Show("Selecione o tipo da conta bancária.");
                }
                else
                {
                    colaboradorModel.IdPessoa = Convert.ToInt32(txtId.Text);
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

                    _controller.AtualizarColaborador(colaboradorModel);
                    this.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao tentar gravar");
            }
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
                    colaboradorModel.Id = int.Parse(txtId.Text);
                    _controllerExcluir.ExcluirColaborador(colaboradorModel);
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
    }

}
