using AugustusFahsion.Controller;
using AugustusFahsion.Controller.Relatorios;
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

        private void BtnFechar_Click(object sender, EventArgs e) => MDISingleton.InstaciaMDI().Close();

        private void btnAdicionarVenda_Click(object sender, EventArgs e) => new VendaRegistrarController().AbrirFormulario();

        private void btnListarVendas_Click(object sender, EventArgs e) => new VendaListarController().AbrirLista();

        private void btnListarColaborador_Click(object sender, EventArgs e) => new ColaboradorListarController().AbrirLista();


        private void lblVendas_MouseClick(object sender, MouseEventArgs e)
        {
            panelVendas.Visible = true;
            panelRelatorios.Visible = false;
        }

        private void label10_MouseClick(object sender, MouseEventArgs e)
        {
            panelVendas.Visible = false;
            panelRelatorios.Visible = true;
        }


        private void btnRelatorioClientes_Click_1(object sender, EventArgs e) => new RelatorioDeClientesController().AbrirRelatorio();

        private void btnRelatorioProdutos_Click_1(object sender, EventArgs e) => new RelatorioDeProdutosController().AbrirRelatorio();
    }
}
