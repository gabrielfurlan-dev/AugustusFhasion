using AugustusFahsion.Controller;
using AugustusFahsion.Controller.Venda;
using System;
using System.Windows.Forms;

namespace AugustusFahsion
{
    public partial class Home : Form
    {
        public Home() => InitializeComponent();

        private void btnCadastrarCliente_Click(object sender, EventArgs e) => new ClienteCadastrarController().AbrirFormulario();
        
        private void btnListarCliente_Click(object sender, EventArgs e) => new ClienteListarController().AbrirLista();
        
        private void BtnCadastrarColaborador_Click(object sender, EventArgs e) => new ColaboradorCadastrarController().AbrirFormulario();

        private void BtnCadastrarProduto_Click(object sender, EventArgs e) => new ProdutoCadastrarController().AbrirFormulario();

        private void BtnListarProduto_Click(object sender, EventArgs e) => new ProdutoListarController().AbrirLista();

        private void BtnFechar_Click(object sender, EventArgs e) => this.Close();

        private void btnAdicionarVenda_Click(object sender, EventArgs e) => new VendaRegistrarController().AbrirFormulario();

        private void btnListarVendas_Click(object sender, EventArgs e) => new VendaListarController().AbrirLista();

        private void btnListarColaborador_Click(object sender, EventArgs e) => new ColaboradorListarController().AbrirLista();

        private void BtnRelatorio_Click(object sender, EventArgs e) => new RelatorioDeProdutosController().AbrirRelatorio();
    }
}
