using AugustusFahsion.DAO;
using AugustusFahsion.Model.Venda;
using AugustusFahsion.View.Venda;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AugustusFahsion.Controller.Venda
{
    public class VendaListarController
    {

        public void AbrirLista() =>
            new FrmVendaListar(this).Show();
        
        public List<VendaListagemModel> ListarVendas()
        {
            try
            {
                var lista = VendaDAO.ListarVendas();
                return lista;
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
            return new List<VendaListagemModel>();
        }

        public List<VendaListagemModel> ListarVendaSelecionada(int idVenda)
        {
            try
            {
                var lista = VendaDAO.ListarVendaSelecionada(idVenda);
                return lista;
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
            return new List<VendaListagemModel>();
        }
        public List<VendaProdutoModel> ListarProdutosDaVenda(int idVenda) 
        {
            try
            {
                return VendaDAO.ListarProdutosDaVenda(idVenda);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return new List<VendaProdutoModel>();
        }

        internal static List<VendaListagemModel> FiltrarPorData(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                return VendaDAO.FiltrarPorData(dataInicial, dataFinal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return new List<VendaListagemModel>();
        }

        public List<VendaListagemModel> FiltrarPorCliente(string nomeCliente)
        {
            try
            {
                return VendaDAO.FiltrarPorCliente(nomeCliente);
                
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
            return new List<VendaListagemModel>();
        }

        public List<VendaListagemModel> FiltrarPorColaborador(string nomeColaborador)
        {
            try
            {
                return VendaDAO.FiltrarPorColaborador(nomeColaborador);

            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
            return new List<VendaListagemModel>();
        }

        public List<VendaListagemModel> FiltrarPorProduto(string nomeProduto)
        {
            try
            {
                return VendaDAO.FiltrarPorProduto(nomeProduto);

            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
            return new List<VendaListagemModel>();
        }
    }
}
