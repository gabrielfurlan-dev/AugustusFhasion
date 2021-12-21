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
        public void AbrirFormulario()
        {
            var child = new FrmVendaRegistrar(this);
            child.MdiParent = MDISingleton.InstaciaMDI();
            child.Show();
        }

        internal ClienteModel ProcurarCliente()
        {
            var form = new FrmSelecionarModel(new ClienteListarController());
            form.ShowDialog();
            return form.Cliente;
        }

        internal ColaboradorModel ProcurarColaborador()
        {
            var form = new FrmSelecionarModel(new ColaboradorListarController());
            form.ShowDialog();
            return form.Colaborador;
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

        public ClienteModel BuscarCliente(int id) => ClienteAlterarController.Buscar(id);

    }
}
