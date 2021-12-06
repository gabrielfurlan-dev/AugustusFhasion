using AugustusFahsion.DAO;
using AugustusFahsion.Model.Relatorio;
using AugustusFahsion.Model.Venda;
using AugustusFahsion.View.Venda;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AugustusFahsion.Controller.Venda
{
    public class RelatorioDeProdutosController
    {
        public void AbrirRelatorio() =>
            new FrmRelatorioDeProdutos(this).Show();

        internal List<RelatorioProdutos> Filtrar(FiltrosRelatorioProduto filtros) => RelatorioDAO.Filtrar(filtros);
    }
}
