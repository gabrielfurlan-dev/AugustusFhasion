using AugustusFahsion.View;

namespace AugustusFahsion.Controller
{
    public class HomeController
    {
        public static void AbrirHome(MDIParent mdi)
        {
            var home = new Home();
            home.MdiParent = mdi;
            home.Show();
        }
    }
}
