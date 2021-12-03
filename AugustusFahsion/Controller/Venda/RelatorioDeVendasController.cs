using AugustusFahsion.View.Venda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustusFahsion.Controller.Venda
{
    public class RelatorioDeVendasController
    {
        public void AbrirRelatorio() =>
            new FrmRelatorioDeVendas(this).Show();
    }
}
