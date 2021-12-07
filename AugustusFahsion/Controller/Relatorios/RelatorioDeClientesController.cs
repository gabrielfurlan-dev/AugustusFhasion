using AugustusFahsion.View.Relatorios;

namespace AugustusFahsion.Controller.Relatorios
{
    public class RelatorioDeClientesController
    {
        public void AbrirRelatorio() =>
           new FrmRelatorioDeClientes(this).Show();
            
        //internal List<RelatorioProdutos> Filtrar(FiltrosRelatorioProduto filtros) => RelatorioDAO.Filtrar(filtros);
    }
}
