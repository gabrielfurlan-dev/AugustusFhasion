using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AugustusFahsion.Controller;

namespace AugustusFahsion
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new ClienteCadastrarController().AbrirFormulario();
        }

        private void colaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ColaboradorCadastrarController().AbrirFormulario();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ClienteListarController().AbrirLista();
        }

        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new ClienteAlterarController().AbrirFormulario();
        }

        private void clienteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new ClienteExcluirController().AbrirFormulario();
        }

        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ColaboradorListarController().AbrirLista();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void colaboradorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ColaboradorAlterarController().AbrirFormulario();
        }

        private void colaboradorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new ColaboradorExcluirController().AbrirFormulario();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProdutoCadastrarController().AbrirFormulario();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ProdutoListarController().AbrirLista();
        }

        private void produtoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new ProdutoAlterarController().AbrirFormulario();
        }

        private void produtoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new ProdutoExcluirController().AbrirFormulario();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            new ClienteCadastrarController().AbrirFormulario();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            new ClienteExcluirController().AbrirFormulario();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new ClienteAlterarController().AbrirFormulario();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            new ClienteListarController().AbrirLista();
        }

        private void btnCadastrarColaborador_Click(object sender, EventArgs e)
        {
            new ColaboradorCadastrarController().AbrirFormulario();
        }

        private void btnExcluirColaborador_Click(object sender, EventArgs e)
        {
            new ColaboradorExcluirController().AbrirFormulario();
        }

        private void btnAlterarColaborador_Click(object sender, EventArgs e)
        {
            new ColaboradorAlterarController().AbrirFormulario();
        }

        private void btnListarColaborador_Click(object sender, EventArgs e)
        {
            new ColaboradorListarController().AbrirLista();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            new ProdutoCadastrarController().AbrirFormulario();
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            new ProdutoExcluirController().AbrirFormulario();
        }

        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {
            new ProdutoAlterarController().AbrirFormulario();
        }

        private void btnListarProduto_Click(object sender, EventArgs e)
        {
            new ProdutoListarController().AbrirLista();
        }
    }
}
