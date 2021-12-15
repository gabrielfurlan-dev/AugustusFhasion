using AugustusFahsion.DAO;
using AugustusFahsion.Model.Relatorio;
using AugustusFahsion.View.Venda;
using System.Collections.Generic;

namespace AugustusFahsion.Controller.Venda
{
    public class RelatorioDeProdutosController
    {
        public void AbrirRelatorio()
        {
            var child = new FrmRelatorioDeProdutos(this);
            child.MdiParent = MDISingleton.InstaciaMDI();
            child.Show();
        }
        internal List<RelatorioProdutos> FiltrarRelatorioProdutos(FiltrosRelatorioProdutos filtros) => RelatorioDAO.FiltrarRelatorioProdutos(filtros);
    }
}
