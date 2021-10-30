using System;
using System.Windows.Forms;
using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using AugustusFahsion.View.Excluir;

namespace AugustusFahsion.Controller
{
    public class ColaboradorExcluirController
    {
        public void AbrirFormulario() =>
            new ColaboradorExcluir(this).Show();

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
        public void ExcluirColaborador(ColaboradorModel colaborador)
        {
            try
            {
                    ColaboradorDAO.ExcluirColaborador(colaborador);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }

        }
    }
}


