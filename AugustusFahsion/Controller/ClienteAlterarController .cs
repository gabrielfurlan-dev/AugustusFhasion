using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AugustusFahsion.Controller;
using AugustusFahsion.View;
using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using System.Windows.Forms;


namespace AugustusFahsion.Controller
{
    public class ClienteAlterarController
    {
        public void AbrirFormulario() =>
            new ClienteAlterar(this).Show();


        public bool ValidarId(int id)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    return ClienteDao.ValidaId(conexao, id);
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
                return false;
            }
        }

        public void AtualizarCliente(ClienteModel clienteModel)
        {

            try
            {
                using (var conexao = new SqlConexao().Connection())
                    if (ClienteDao.ValidaId(conexao, clienteModel.Id))
                    {
                        {
                            conexao.Open();
                            ClienteDao.AlterarCliente(conexao, clienteModel);
                            MessageBox.Show("Cliente alterado!");
                        }
                    }
            }


            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
        }


    }
}


