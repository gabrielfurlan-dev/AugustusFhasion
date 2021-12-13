using AugustusFahsion.DAO;
using AugustusFahsion.Model.Relatorio;
using AugustusFahsion.View.Relatorios;
using System.Collections.Generic;

namespace AugustusFahsion.Controller.Relatorios
{
    public class RelatorioDeClientesController
    {
        public void AbrirRelatorio()
        {
            var child = new FrmRelatorioDeClientes(this);
            child.MdiParent = MDISingleton.InstaciaMDI();
            child.Show();
        }

        internal List<RelatorioClientes> FiltrarRelatorioClientes(FiltrosRelatorioClientes filtros) => RelatorioDAO.FiltrarRelatorioClientes(filtros);
    }
}
