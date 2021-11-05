using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using AugustusFahsion.View;
using System;
using System.Windows.Forms;


namespace AugustusFahsion.Controller
{
    public class ClienteAlterarController
    {
        public void AbrirFormulario() =>
            new ClienteAlterar(this).Show();

        public void AbrirFormulario(ClienteModel clienteModelSelecionado)
        {
            ClienteExcluirController clienteExcluirController = new ClienteExcluirController();
            new ClienteAlterar(this, clienteModelSelecionado, clienteExcluirController).Show();
        }


        public bool ValidarId(int id)
        {
            try
            {
<<<<<<< HEAD
                return ClienteDAO.ValidaId(id);
=======

                    return ClienteDao.ValidaId(id);
>>>>>>> parent of 0fbe93f (Adicionado funcionalidade de busca personalizada)
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
                return false;
            }
        }

        public static ClienteModel Buscar(int id)
        {
<<<<<<< HEAD
                return ClienteDAO.Buscar(id);
=======
            using (var conexao = new SqlConexao().Connection())
            {

                return ClienteDao.Buscar(conexao, id);
            }
>>>>>>> parent of 0fbe93f (Adicionado funcionalidade de busca personalizada)
        }

        public void AtualizarCliente(ClienteModel clienteModel)
        {
            try
            {
<<<<<<< HEAD
                if (ClienteDAO.ValidaId(clienteModel.IdPessoa))
                {
                    ClienteDAO.AlterarCliente(clienteModel);
                    MessageBox.Show("Cliente alterado!");
=======
                if (ClienteDao.ValidaId(clienteModel.Id))
                {
                    {
                        ClienteDao.AlterarCliente(clienteModel);
                        MessageBox.Show("Cliente alterado!");
                    }
>>>>>>> parent of 0fbe93f (Adicionado funcionalidade de busca personalizada)
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
        }
    }
}


