using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.Controller.Venda
{
    public class VendaExcluirController
    {
        public static void ExcluirVenda(VendaModel venda) 
        {
            try
            {
                VendaDAO.ExcluirVenda(venda);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
        }
    }
}
