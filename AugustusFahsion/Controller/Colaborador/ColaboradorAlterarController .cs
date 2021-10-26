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

        public ColaboradorModel Buscar(int id)
        {
            using (var conexao = new SqlConexao().Connection())
            {
                conexao.Open();
                return ColaboradorDAO.Buscar(conexao, id);
            }
        }

        public void AtualizarColaborador(ColaboradorModel colaboradorModel)
        {

            try
            {
                using (var conexao = new SqlConexao().Connection())

                if (ColaboradorDAO.ValidaId(conexao, colaboradorModel.Id))
                {
                    {
                        conexao.Open();
                            ColaboradorDAO.AlterarColaborador(conexao, colaboradorModel);
                        MessageBox.Show("Colaborador alterado!");
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


