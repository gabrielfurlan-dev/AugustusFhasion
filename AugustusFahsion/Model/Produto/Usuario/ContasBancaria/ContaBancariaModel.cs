using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustusFahsion.Model.ContasBancaria
{
    public class ContaBancariaModel
    {
        public int IdPessoa { get; set; }
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public string TipoConta { get; set; }
    }
}