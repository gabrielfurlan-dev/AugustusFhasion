using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AugustusFahsion.View
{
    public partial class ClienteAlterar : Form
    {
        private ClienteAlterarController _controllerAlterar;
        private ClienteExcluirController _controllerExcluir;
        private ClienteModel clienteModel;

        public ClienteAlterar(ClienteAlterarController clienteAlterarController)
        {
            InitializeComponent();

            _controllerAlterar = clienteAlterarController;
            clienteModel = new ClienteModel { };
        }

        public ClienteAlterar(ClienteAlterarController clienteAlterarController,
            ClienteModel clienteModelSelecionado,
            ClienteExcluirController clienteExcluirController
            )
        {
            InitializeComponent();

            _controllerAlterar = clienteAlterarController;
            clienteModel = clienteModelSelecionado;

            AtribuirModelParaCampos(clienteModelSelecionado);
            btnSalvar.Enabled = true;
            _controllerExcluir = clienteExcluirController;
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
                    clienteModel.ValorLimiteAPrazo = double.Parse(nupValorLimiteAPrazo.Text);
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

                    _controllerAlterar.AtualizarCliente(clienteModel);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao tentar gravar");
            }
        }
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {
                e.Handled = true;
            }
        }
        public void AtribuirModelParaCampos(ClienteModel clienteModel)
        {
            txtId.Text = clienteModel.Id.ToString();
            txtNome.Text = clienteModel.Nome;
            txtSobrenome.Text = clienteModel.Sobrenome;
            dtpDataNascimento.Text = clienteModel.DataNascimento.ToString();
            cbSexo.Text = clienteModel.Sexo;
            mtxtCep.Text = clienteModel.Cep.ToString();
            nupValorLimiteAPrazo.Value = (decimal)clienteModel.ValorLimiteAPrazo;
            txtLogradouro.Text = clienteModel.Logradouro;
            txtCidade.Text = clienteModel.Cidade;
            cbUf.Text = clienteModel.Uf;
            txtComplemento.Text = clienteModel.Complemento;
            txtBairro.Text = clienteModel.Bairro;
            txtNumeroEndereco.Text = clienteModel.NumeroEndereco.ToString();
            txtTelefone.Text = clienteModel.Telefone.ToString();
            mtxtCelular.Text = clienteModel.Celular.ToString();
            txtEmail.Text = clienteModel.Email;
            mtxtCpf.Text = clienteModel.Cpf;
        }

        private void btnConsultarId_Click_1(object sender, EventArgs e)
        {
            int id;
            Int32.TryParse(txtId.Text, out id);

            var validaID = new ClienteAlterarController().ValidarId(id);
            if (id > 0 && validaID)
            {
                clienteModel.Id = int.Parse(txtId.Text);
                MessageBox.Show("id válido!");
                clienteModel = ClienteAlterarController.Buscar(int.Parse(txtId.Text));

                //AtribuirModelParaCampos();

                btnSalvar.Enabled = true;
            }
            else
            {
                MessageBox.Show("id invalido!");
            }
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
                    _controllerExcluir.ExcluirCliente(clienteModel);
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
