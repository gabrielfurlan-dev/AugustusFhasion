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
    public class ColaboradorCadastrarController
    {
        public void AbrirFormulario() =>
            new ColaboradorCadastrar(this).Show();

        public void CadastrarColaborador(ColaboradorModel colaboradorModel)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    ColaboradorDAO.CadastrarColaborador(conexao, colaboradorModel);
                    MessageBox.Show("Colaborador cadastrado.");
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
        }

        public List<ColaboradorModel> ListarColaboradores()
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    var lista = ColaboradorDAO.ListarColaboradores(conexao);
                    return lista;
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }

            return new List<ColaboradorModel>();
        }
    }
}


