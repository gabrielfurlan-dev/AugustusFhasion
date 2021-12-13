using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using AugustusFahsion.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AugustusFahsion.Controller
{
    public class ClienteListarController
    {
        public void AbrirLista()
        {
            var child = new FrmClienteListar(this);
            child.MdiParent = MDISingleton.InstaciaMDI();
            child.Show();
        }

        public List<ClienteListagemModel> ListarClientes()
        {
            try
            {
                var lista = ClienteDAO.ListarClientes();
                return lista;
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }

            return new List<ClienteListagemModel>();
        }

        public List<ClienteListagemModel> ListarClientesPorId(int id)
        {
            try
            {
                var lista = ClienteDAO.BuscarClientePorId(id);
                return lista;
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }

            return new List<ClienteListagemModel>();
        }

        public List<ClienteListagemModel> ListarClientesPorNome(string nome)
        {
            try
            {
                var lista = ClienteDAO.BuscarClientePorNome(nome);
                return lista;
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
            return new List<ClienteListagemModel>();
        }
    }
}