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
        public void AbrirLista() =>
            new ClienteListar(this).Show();


        public List<ClienteListagem> ListarClientes()
        {
            try
            {
                var lista = ClienteDao.ListarClientes();
                return lista;
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }

            return new List<ClienteListagem>();
        }
    }
}
