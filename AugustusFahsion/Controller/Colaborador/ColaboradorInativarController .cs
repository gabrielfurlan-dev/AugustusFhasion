using System;
using System.Windows.Forms;
using AugustusFahsion.DAO;
using AugustusFahsion.Model;
namespace AugustusFahsion.Controller
{
    public class ColaboradorExcluirController
    {
        public void Inativar(ColaboradorModel colaborador)
        {
            try
            {
                    ColaboradorDAO.InativarColaborador(colaborador);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }

        }
        
        //==============================
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
    }
}


