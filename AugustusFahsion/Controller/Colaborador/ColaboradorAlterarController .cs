    using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using AugustusFahsion.View.Alterar;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.Controller
{
    public class ColaboradorAlterarController
    {
        public void AbrirFormulario()
        {
            var form = new FrmColaboradorAlterar(this);
            form.MdiParent = MDISingleton.InstaciaMDI();
            form.Show();
        }

        public void AbrirFormulario(ColaboradorModel colaboradorModelSelecionado)
        {
            ColaboradorExcluirController colaboradorExcluirController = new ColaboradorExcluirController();
            var form = new FrmColaboradorAlterar(this, colaboradorModelSelecionado, colaboradorExcluirController);
            form.MdiParent = MDISingleton.InstaciaMDI();
            form.Show();
        }
        public static ColaboradorModel Buscar(int id) => ColaboradorDAO.Buscar(id);
        public void AtualizarColaborador(ColaboradorModel colaboradorModel)
        {
            try
            {
                if (!ColaboradorDAO.ValidaId(colaboradorModel.IdColaborador)) return;

                ColaboradorDAO.AlterarColaborador(colaboradorModel);
                MessageBox.Show("Colaborador alterado!");
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