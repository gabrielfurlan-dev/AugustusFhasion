using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using AugustusFahsion.View.Venda;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.View.Selecao
{
    public partial class FrmSelecionarModel : Form
    {
        ClienteListarController _clienteListarController;
        ClienteModel _cliente;

        ColaboradorListarController _colaboradorListarController;
        ColaboradorModel _colaborador;

        ProdutoListarController _produtoListarController;
        ProdutoModel _produto;

        public ClienteModel Cliente { get { return _cliente; } }
        public ColaboradorModel Colaborador { get { return _colaborador; } }

        public FrmSelecionarModel(ClienteListarController clienteListarController)
        {
            InitializeComponent();
            _clienteListarController = clienteListarController;
        }
        public FrmSelecionarModel(ColaboradorListarController colaboradorListarController)
        {
            InitializeComponent();
            _colaboradorListarController = colaboradorListarController;

        }
        public FrmSelecionarModel(ProdutoListarController produtoListarController)
        {
            InitializeComponent();
            _produtoListarController = produtoListarController;
            
            return;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(_clienteListarController != null)
                PesquisarCliente();
            else if(_colaboradorListarController != null)
                    PesquisaColaborador();
            else
                PesquisarProduto();
        }
        private void PesquisarProduto()
        {
            if (Validacoes.EhNumerico(txtProcurar.Text))
            {
                dgvLista.DataSource = _produtoListarController.ListarProdutosPorId(int.Parse(txtProcurar.Text));
            }
            else if (txtProcurar.Text == "%")
            { 
                dgvLista.DataSource = _produtoListarController.ListarProdutos();
            }
            else
            {
                dgvLista.DataSource = _produtoListarController.ListarProdutosPorNome(txtProcurar.Text);
            }
        }
        private void PesquisaColaborador()
        {
            if (Validacoes.EhNumerico(txtProcurar.Text))
            {
                dgvLista.DataSource = _colaboradorListarController.ListarColaboradorPorId(int.Parse(txtProcurar.Text));
            }
            else if (txtProcurar.Text == "%")
            {
                dgvLista.DataSource = _colaboradorListarController.ListarColaborador();
            }
            else
            {
                dgvLista.DataSource = _colaboradorListarController.ListarColaboradorPorNome(txtProcurar.Text);
            }
        }
        private void PesquisarCliente() 
        {
            if (Validacoes.EhNumerico(txtProcurar.Text))
            {
                dgvLista.DataSource = _clienteListarController.ListarClientesPorId(int.Parse(txtProcurar.Text));
            }
            else if (txtProcurar.Text == "%")
            {
                dgvLista.DataSource = _clienteListarController.ListarClientes();
            }
            else
            {
                dgvLista.DataSource = _clienteListarController.ListarClientesPorNome(txtProcurar.Text);
            }
        }

        private void dgvLista_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var idSelecionado = Convert.ToInt32(dgvLista.SelectedRows[0].Cells[0].Value);

            if (_clienteListarController != null)
            {
                _cliente = ClienteAlterarController.Buscar(idSelecionado);
            }
            else if (_colaboradorListarController != null)
            {
                _colaborador = ColaboradorAlterarController.Buscar(idSelecionado);
            }
            else
            {
                _produto = ProdutoAlterarController.Buscar(idSelecionado);
            }

        }
    }
}
