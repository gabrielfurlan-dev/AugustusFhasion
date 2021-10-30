﻿using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using AugustusFahsion.View;
using AugustusFahsion.View.Cadastrar;
using System;
using System.Windows.Forms;


namespace AugustusFahsion.Controller
{
    public class ColaboradorCadastrarController
    {
        public void AbrirFormulario() =>
            new ColaboradorCadastrar(this).Show();

        public void CadastrarColaborador(ColaboradorModel colaboradorModel)
        {
            try
            {
                    ColaboradorDAO.CadastrarColaborador(colaboradorModel);
                    MessageBox.Show("Colaborador cadastrado.");
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
        }
    }
}


