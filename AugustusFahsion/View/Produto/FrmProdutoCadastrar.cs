using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace AugustusFahsion.View
{

    public partial class FrmProdutoCadastrar : Form
    {
        Bitmap _bitmap;
        byte[] _foto;

        private ProdutoCadastrarController _controller;
        private ProdutoModel produtoModel;
        public FrmProdutoCadastrar(ProdutoCadastrarController produtoCadastrarController)
        {
            InitializeComponent();
            _controller = produtoCadastrarController;
            produtoModel = new ProdutoModel { };
        }


        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                PreencherCamposModel();

                _controller.CadastrarProduto(produtoModel);
                this.Close();
            }
        }

        private bool ValidarCampos()
        {
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Insira um nome.");
                return false;
            }
            if (String.IsNullOrEmpty(txtFabricante.Text))
            {
                MessageBox.Show("Insira uma marca");
                return false;
            }
            if (nupPrecoCusto.Value < 0)
            {
                MessageBox.Show("Insira um preço de custo válido");
                return false;
            }
            if (nupPrecoVenda.Value < 0)
            {
                MessageBox.Show("Insira um preço de venda válido");
                return false;
            }
            return true;
        }

        private void PreencherCamposModel()
        {
            produtoModel.Nome = txtNome.Text;
            produtoModel.Fabricante = txtFabricante.Text;
            produtoModel.PrecoCusto = nupPrecoCusto.Value;
            produtoModel.PrecoVenda = nupPrecoVenda.Value;
            produtoModel.CodigoBarras = mtxtCodigoBarras.Text;
            produtoModel.QuantidadeEstoque = (int)nupQuantidadeEstoque.Value;
            produtoModel.Condicao = cbCondicao.Text;

            produtoModel.ImagemProduto = _foto;
        }

        private void BtnAdicionarImagem_Click(object sender, EventArgs e)
        {
            if (OfdInserirImagemProduto.ShowDialog() == DialogResult.OK) 
            {
                string nome = OfdInserirImagemProduto.FileName;
                MemoryStream memory = new MemoryStream();

                _bitmap = new Bitmap(nome);
                
                //PtbImagemProduto.ImageLocation = OfdInserirImagemProduto.FileName;
                PtbImagemProduto.Image = _bitmap;
                LblCaminhoImagem.Text = OfdInserirImagemProduto.FileName;
                //PtbImagemProduto.Load();

                //converter a imagem em byte
                MemoryStream memoryStream = new MemoryStream();
                _bitmap.Save(memoryStream, ImageFormat.Bmp);
                _foto = memoryStream.ToArray();

                lblInsiraUmaImagem.Visible = false;
                BtnAdicionarImagem.Text = "Alterar";
            }
        }

        private void btnRemoverImagem_Click(object sender, EventArgs e)
        {
            PtbImagemProduto.Image = null;
            lblInsiraUmaImagem.Visible = true;
            BtnAdicionarImagem.Text = "Adicionar";
        }
    }
}
