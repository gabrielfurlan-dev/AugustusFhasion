using AugustusFahsion.Controller;
using System;
using System.Windows.Forms;

namespace AugustusFahsion.View
{
    public partial class MDIParentPrincipal : Form
    {
        private int childFormNumber = 0;

        public MDIParentPrincipal()
        {
            InitializeComponent();
        }

        private void MDIParentPrincipal_Load(object sender, EventArgs e)
        {
            new HomeController().AbrirHome();
        }
    }
}
