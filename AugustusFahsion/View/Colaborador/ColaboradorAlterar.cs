using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AugustusFahsion.View.Alterar
{
    public partial class ColaboradorAlterar : Form
    {
        private ColaboradorAlterarController _controller;
        private ColaboradorModel colaboradorModel;
        public ColaboradorAlterar(ColaboradorAlterarController colaboradorAlterarController)
        {
            InitializeComponent();

            _controller = colaboradorAlterarController;


            colaboradorModel = new ColaboradorModel { };
        }

        public ColaboradorAlterar(ColaboradorAlterarController colaboradorAlterarController, ColaboradorModel colaboradorModelSelecionado)
        {
            InitializeComponent();

            _controller = colaboradorAlterarController;
            colaboradorModel = colaboradorModelSelecionado;

            AtribuirModelParaCampos();
            btnSalvar.Enabled = true;
        }

        private void AtribuirModelParaCampos()
        {
            txtNome.Text = colaboradorModel.Nome;
            txtSobrenome.Text = colaboradorModel.Sobrenome;
            dtpDataNascimento.Text = colaboradorModel.DataNascimento.ToString();
            cbSexo.Text = colaboradorModel.Sexo;
            mtxtCep.Text = colaboradorModel.Cep.ToString();
            nupSalario.Value = (decimal)colaboradorModel.Salario;
            nupComissao.Value = colaboradorModel.Comissao;
            txtLogradouro.Text = colaboradorModel.Logradouro;
            txtCidade.Text = colaboradorModel.Cidade;
            cbUf.Text = colaboradorModel.Uf;
            txtComplemento.Text = colaboradorModel.Complemento;
            txtBairro.Text = colaboradorModel.Bairro;
            txtNumeroEndereco.Text = colaboradorModel.NumeroEndereco.ToString();
            txtTelefone.Text = colaboradorModel.Telefone.ToString();
            mtxtCelular.Text = colaboradorModel.Celular.ToString();
            txtEmail.Text = colaboradorModel.Email;
            mtxtCpf.Text = colaboradorModel.Cpf;

            txtBanco.Text = colaboradorModel.Banco;
            mtxtAgencia.Text = colaboradorModel.Agencia;
            cbTipoConta.Text = colaboradorModel.TipoConta;
            mtxtConta.Text = colaboradorModel.Conta;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarId_Click(object sender, EventArgs e)
        {
            int id;
            Int32.TryParse(txtId.Text, out id);

            var validaID = new ColaboradorAlterarController().ValidarId(id);
            if (id > 0 && validaID)
            {
                colaboradorModel.Id = int.Parse(txtId.Text);
                MessageBox.Show("id válido!");
                colaboradorModel = _controller.Buscar(Int32.Parse(txtId.Text));


                txtNome.Text = colaboradorModel.Nome;
                txtSobrenome.Text = colaboradorModel.Sobrenome;
                dtpDataNascimento.Text = colaboradorModel.DataNascimento.ToString();
                cbSexo.Text = colaboradorModel.Sexo;
                nupSalario.Value = (decimal)colaboradorModel.Salario;
                nupComissao.Value = colaboradorModel.Comissao;
                mtxtCep.Text = colaboradorModel.Cep.ToString();
                txtLogradouro.Text = colaboradorModel.Logradouro;
                txtCidade.Text = colaboradorModel.Cidade;
                cbUf.Text = colaboradorModel.Uf;
                txtComplemento.Text = colaboradorModel.Complemento;
                txtBairro.Text = colaboradorModel.Bairro;
                txtNumeroEndereco.Text = colaboradorModel.NumeroEndereco.ToString();
                txtTelefone.Text = colaboradorModel.Telefone.ToString();
                mtxtCelular.Text = colaboradorModel.Celular.ToString();
                txtEmail.Text = colaboradorModel.Email;
                mtxtCpf.Text = colaboradorModel.Cpf;

                txtBanco.Text = colaboradorModel.Banco;
                mtxtAgencia.Text = colaboradorModel.Agencia.ToString();
                mtxtConta.Text = colaboradorModel.Conta.ToString();
                cbTipoConta.Text = colaboradorModel.TipoConta;

                btnSalvar.Enabled = true;
            }
            else
            {
                MessageBox.Show("id invalido!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
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

                    _controller.AtualizarColaborador(colaboradorModel);
                    this.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao tentar gravar");
            }
        }
    }

}
