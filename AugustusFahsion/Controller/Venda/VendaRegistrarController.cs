using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using AugustusFahsion.Model.Venda;
using AugustusFahsion.View.Venda;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.Controller.Venda
{
    public class VendaRegistrarController
    {
        public void AbrirFormulario() =>
            new FrmVendaRegistrar(this).Show();

        public void RegistrarVenda(VendaModel vendaModel) {
            try
            {
                VendaDAO.RegistrarVenda(vendaModel);
                MessageBox.Show("Venda Registrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void AtualizarEstoque(VendaModel vendaModel)
        {
            try
            {
                VendaDAO.AtualizarEstoque(vendaModel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
