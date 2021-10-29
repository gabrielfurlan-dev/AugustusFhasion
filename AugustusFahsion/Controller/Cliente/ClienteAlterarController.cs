﻿using AugustusFahsion.DAO;
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

        public void AbrirFormulario(ClienteModel clienteModelSelecionado) =>
            new ClienteAlterar(this, clienteModelSelecionado).Show();


        public bool ValidarId(int id)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                { 
                    return ClienteDao.ValidaId(conexao, id);
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
                return false;
            }
        }

        public static ClienteModel Buscar(int id)
        {
            using (var conexao = new SqlConexao().Connection())
            {

                return ClienteDao.Buscar(conexao, id);
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


