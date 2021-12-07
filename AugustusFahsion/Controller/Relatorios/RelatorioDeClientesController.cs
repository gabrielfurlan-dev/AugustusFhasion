using AugustusFahsion.DAO;
using AugustusFahsion.Model.Relatorio;
using AugustusFahsion.View.Relatorios;
using System.Collections.Generic;

namespace AugustusFahsion.Controller.Relatorios
{
    public class RelatorioDeClientesController
    {
        public void AbrirRelatorio() =>
           new FrmRelatorioDeClientes(this).Show();
            
        internal List<RelatorioClientes> FiltrarRelatorioClientes(FiltrosRelatorioClientes filtros) => RelatorioDAO.FiltrarRelatorioClientes(filtros);
    }
}
