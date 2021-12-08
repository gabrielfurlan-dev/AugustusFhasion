using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using AugustusFahsion.Model.ValueObjects;
using AugustusFahsion.View.Selecao;
using AugustusFahsion.View.Venda;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.Controller.Venda
{
    public class  VendaRegistrarController
    {
        public void AbrirFormulario() =>
            new FrmVendaRegistrar(this).Show();

        internal void ProcurarCliente()
        {
            new FrmSelecionarModel(new ClienteListarController()).Show();
        }

        internal void ProcurarColaborador()
        {
            new FrmSelecionarModel(new ColaboradorListarController()).Show();
        }

        public void RegistrarVenda(VendaModel vendaModel) {
            try
            {
                VendaDAO.RegistrarVenda(vendaModel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static DinheiroModel ValorLimiteGasto(int id)
        {
            try
            {
                return ClienteDAO.ValorLimiteGasto(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
