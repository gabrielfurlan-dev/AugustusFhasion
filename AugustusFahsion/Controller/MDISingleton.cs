using AugustusFahsion.View;

namespace AugustusFahsion.Controller
{
    public class MDISingleton
    {
        public MDISingleton()
        {

        }

        private static MDIParentPrincipal _instanceDMIParentPrincipal;

        public static MDIParentPrincipal InstaciaMDI()
        {
            if (_instanceDMIParentPrincipal == null)
            {
                return _instanceDMIParentPrincipal = new MDIParentPrincipal();
            }
            return _instanceDMIParentPrincipal;
        }
    }

}
