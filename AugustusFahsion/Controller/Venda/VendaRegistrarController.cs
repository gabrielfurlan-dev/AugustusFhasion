using AugustusFahsion.View.Venda;

namespace AugustusFahsion.Controller.Venda
{
    public class VendaRegistrarController
    {
        public void AbrirFormulario() =>
            new FrmVendaRegistrar(this).Show();
    }
}
