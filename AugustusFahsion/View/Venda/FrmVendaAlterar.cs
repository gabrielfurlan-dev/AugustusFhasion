using AugustusFahsion.Controller.Venda;
using AugustusFahsion.Model;
using AugustusFahsion.Model.Venda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AugustusFahsion.View.Venda
{
    public partial class FrmVendaAlterar : Form
    {
        private VendaAlterarController _controllerAlterar;
        private VendaExcluirController _controllerExcluir;
        private VendaModel vendaModel;
        public FrmVendaAlterar()
        {
            InitializeComponent();
        }
        public FrmVendaAlterar(
            VendaAlterarController vendaAlterarController,
            VendaExcluirController vendaExcluirController,
            VendaModel produtoModelSelecionado
            )
        {
            InitializeComponent();
            _controllerAlterar = vendaAlterarController;
            vendaModel = produtoModelSelecionado;

            AtribuirModelParaCampos(vendaModel);
            _controllerExcluir = vendaExcluirController;
        }

        public void AtribuirModelParaCampos(VendaModel vendaModel) 
        {
            SelecionarVendaModel();
            var id = SelecionarVendaModel();
            var venda = _controllerAlterar.BuscarVenda(id);


        }

        //public VendaModel SelecionarModelVenda(int id) => _controllerAlterar.BuscarVenda(id);
        
        public int SelecionarVendaModel() => Convert.ToInt32(dgvProdutosVenda.SelectedRows[0].Cells[0].Value);

        private void btnExcluirVenda_Click(object sender, EventArgs e)
        {
            //_controllerExcluir.ExcluirVenda();
        }

        private void dgvProdutosVenda_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = SelecionarVendaModel();
            var venda = _controllerAlterar.BuscarVenda(id);

            //lblIdProduto.Text = produto.IdProduto.ToString();
            //lblProdutoSelecionado.Text = produto.Nome;
            //lblPrecoProduto.Text = produto.PrecoVenda.ToString();
            //lblTotalProdutoSemDesconto.Text = (Convert.ToDecimal(produto.PrecoVenda) * nupQuantidade.Value).ToString();
            //lblTotalProdutoComDesconto.Text = (Convert.ToDecimal(produto.PrecoVenda) * nupQuantidade.Value).ToString();
            //AtualizarPrecosProdutoSelecionado();
        }
    }
}
