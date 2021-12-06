using AugustusFahsion.DAO;
using AugustusFahsion.Model.Venda;
using AugustusFahsion.View.Venda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AugustusFahsion.Controller.Venda
{
    public class RelatorioDeProdutosController
    {
        public void AbrirRelatorio() =>
            new FrmRelatorioDeProdutos(this).Show();

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
