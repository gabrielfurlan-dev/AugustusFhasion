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
                using (var conexao = new SqlConexao().Connection())
                {
                    var lista = ClienteDao.ListarClientes(conexao);
                    return lista;
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }

            return new List<ClienteListagem>();
        }
    }
}
