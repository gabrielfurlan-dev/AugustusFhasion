using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using Dapper;
using System;

namespace AugustusFahsion.Controller.Venda
{
    public class VendaAlterarController
    {

        public VendaModel BuscarVenda(int id) => VendaDAO.BuscarVenda(id);
    }
}
