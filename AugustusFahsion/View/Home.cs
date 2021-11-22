using AugustusFahsion.Controller;
using AugustusFahsion.Controller.Venda;
using System;
using System.Windows.Forms;

namespace AugustusFahsion
{
    public partial class Home : Form
    {
        public Home() => InitializeComponent();

        private void ClienteToolStripMenuItem_Click_1(object sender, EventArgs e) =>
            new ClienteCadastrarController().AbrirFormulario();

        private void ColaboradorToolStripMenuItem_Click(object sender, EventArgs e) => 
            new ColaboradorCadastrarController().AbrirFormulario();

        private void ClienteToolStripMenuItem1_Click(object sender, EventArgs e) =>
            new ClienteListarController().AbrirLista();

        private void ClienteToolStripMenuItem2_Click(object sender, EventArgs e) =>
            new ClienteAlterarController().AbrirFormulario();

        private void ColaboradoresToolStripMenuItem_Click(object sender, EventArgs e) =>
            new ColaboradorListarController().AbrirLista();

        private void ColaboradorToolStripMenuItem1_Click(object sender, EventArgs e) =>
            new ColaboradorAlterarController().AbrirFormulario();

        private void ProdutoToolStripMenuItem_Click(object sender, EventArgs e) =>
            new ProdutoCadastrarController().AbrirFormulario();

        private void ProdutoToolStripMenuItem1_Click(object sender, EventArgs e) =>
            new ProdutoListarController().AbrirLista();

        private void ProdutoToolStripMenuItem2_Click(object sender, EventArgs e) =>
            new ProdutoAlterarController().AbrirFormulario();

        private void Button4_Click_1(object sender, EventArgs e) 
        {
            new ClienteCadastrarController().AbrirFormulario();
        }
            

        private void Button2_Click_1(object sender, EventArgs e) =>
            new ClienteAlterarController().AbrirFormulario();
        
        private void Button3_Click_1(object sender, EventArgs e) =>
            new ClienteListarController().AbrirLista();
        
        private void BtnCadastrarColaborador_Click(object sender, EventArgs e) =>
            new ColaboradorCadastrarController().AbrirFormulario();
        
        private void BtnAlterarColaborador_Click(object sender, EventArgs e) =>
            new ColaboradorAlterarController().AbrirFormulario();
    
        private void BtnListarColaborador_Click(object sender, EventArgs e) =>
            new VendaListarController().AbrirLista();

        private void BtnCadastrarProduto_Click(object sender, EventArgs e) =>
            new ProdutoCadastrarController().AbrirFormulario();
        
        private void BtnAlterarProduto_Click(object sender, EventArgs e) =>
            new ProdutoAlterarController().AbrirFormulario();

        private void BtnListarProduto_Click(object sender, EventArgs e) =>
            new ProdutoListarController().AbrirLista();

        private void BtnFechar_Click(object sender, EventArgs e) =>
            this.Close();

        private void btnAdicionarVenda_Click(object sender, EventArgs e)
        {
            new VendaRegistrarController().AbrirFormulario();
        }

        private void btnListarVendas_Click(object sender, EventArgs e)
        {
            new VendaListarController().AbrirLista();
        }
    }
}
