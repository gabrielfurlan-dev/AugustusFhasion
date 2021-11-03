using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustusFahsion.Model
{
    public class ClienteModel: Pessoa
    {
        public int IdCliente { get; set; }

        public double ValorLimiteAPrazo { get; set; }
    }
}
