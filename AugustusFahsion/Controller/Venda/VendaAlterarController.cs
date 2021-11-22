using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using AugustusFahsion.View.Venda;
using Dapper;
using System;

namespace AugustusFahsion.Controller.Venda
{
    public class VendaAlterarController
    {
        public void AbrirFormulario(VendaModel venda) => new FrmVendaAlterar(this, venda).Show();
        public VendaModel BuscarVenda(int id) => VendaDAO.BuscarVenda(id);
    }
}
