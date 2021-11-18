using AugustusFahsion.DAO;
using AugustusFahsion.Model;
using Dapper;
using System;

namespace AugustusFahsion.Controller.Venda
{
    class VendaAlterarController
    {

        public VendaModel BuscarVenda(int id) => VendaDAO.BuscarVenda(id);
    }
}
