namespace AugustusFahsion.Controller
{
    class HomeController
    {
        public void AbrirHome()
        {
            var child = new Home();
            child.MdiParent = MDISingleton.InstaciaMDI();
            child.Show();

        }
    }
}
