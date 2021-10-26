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
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    return ColaboradorDAO.ValidaId(conexao, id);
                }
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
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    ColaboradorDAO.ExcluirColaborador(conexao, colaborador);
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }

        }
    }
}


