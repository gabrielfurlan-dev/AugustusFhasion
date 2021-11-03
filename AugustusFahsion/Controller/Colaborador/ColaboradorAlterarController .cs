using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using AugustusFahsion.View.Alterar;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.Controller
{
    public class ColaboradorAlterarController
    {
        public void AbrirFormulario() =>
            new ColaboradorAlterar(this).Show();
        public void AbrirFormulario(ColaboradorModel colaboradorModelSelecionado)
        {
            ColaboradorExcluirController colaboradorExcluirController = new ColaboradorExcluirController();
            new ColaboradorAlterar(this, colaboradorModelSelecionado, colaboradorExcluirController).Show();
        }
        public bool ValidarId(int id)
        {
            try
            { 
                return ColaboradorDAO.ValidaId(id);       
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
                return false;
            }
        }
        public static ColaboradorModel Buscar(int id)
        {
                return ColaboradorDAO.Buscar(id);
        }
        public void AtualizarColaborador(ColaboradorModel colaboradorModel)
        {
            try
            {
                if (ColaboradorDAO.ValidaId(colaboradorModel.IdPessoa))
                {
                    ColaboradorDAO.AlterarColaborador(colaboradorModel);
                    MessageBox.Show("Colaborador alterado!");
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
        }
    }
}