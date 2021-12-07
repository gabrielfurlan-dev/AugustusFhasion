using AugustusFahsion.DAO;
using AugustusFahsion.Model.Relatorio;
using AugustusFahsion.View.Venda;
using System.Collections.Generic;

namespace AugustusFahsion.Controller.Venda
{
    public class RelatorioDeProdutosController
    {
        public void AbrirRelatorio() =>
            new FrmRelatorioDeProdutos(this).Show();

        internal List<RelatorioProdutos> Filtrar(FiltrosRelatorioProduto filtros) => RelatorioDAO.Filtrar(filtros);
    }
}
