﻿using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using AugustusFahsion.Model.Venda;
using AugustusFahsion.View.Venda;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.Controller.Venda
{
    public class VendaAlterarController
    {
        public void AbrirFormulario(VendaModel venda)
        {
            var child = new FrmVendaAlterar(this, venda);
            child.MdiParent = MDISingleton.InstaciaMDI();
            child.Show();
        }
        public static VendaModel BuscarVenda(int id) => 
            VendaDAO.BuscarVenda(id);

        public static VendaProdutoModel BuscarDadosDoProdutoDaVenda(int idProduto) =>
                VendaDAO.BuscarDadosDoProdutoDaVenda(idProduto);

        public static void InativarVenda(VendaModel vendaModel)
        {
            try
            {
                VendaDAO.InativarVenda(vendaModel);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
        }
        public static void AlterarVenda(VendaModel vendaModel)
        {
            try
            {
                VendaDAO.AlterarVenda(vendaModel);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
        }

        internal static int BuscarQuantidadeOriginalDaVenda(int idProduto, int IdVenda)
        {
            return VendaDAO.BuscarQuantidadeOriginalDaVenda(idProduto, IdVenda);
        }

        internal static int BuscarEstoqueOriginal(int idProduto)
        {
            return ProdutoDAO.BuscarEstoqueOriginal(idProduto);
        }

        public static decimal ValorTotalBrutoProduto(decimal precoProduto, int quantidade) => (precoProduto) * quantidade;

        public static decimal ValorTotalDesconto(int desconto, int quantidade, decimal precoProduto)
        {
            var valorTotalBrutoProduto = VendaAlterarController.ValorTotalBrutoProduto(precoProduto, quantidade);
            return valorTotalBrutoProduto - (valorTotalBrutoProduto * (desconto * Convert.ToDecimal(0.01)));
        }

        public static decimal ValorTotalDescontoProduto(int desconto, int quantidade, decimal precoProduto) => 
            ValorTotalBrutoProduto(precoProduto, quantidade) - ValorTotalDesconto(desconto, quantidade, precoProduto);

        public static decimal ValorProdutoLucro(decimal ProdutoLucroUnitario, int desconto, int quantidade, decimal precoProduto) =>
            (ProdutoLucroUnitario * quantidade) - ValorTotalDescontoProduto(desconto, quantidade, precoProduto);
    }
}
