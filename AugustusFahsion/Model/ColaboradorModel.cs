using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustusFahsion.Model
{
    public class ColaboradorModel: Pessoa
    {
       
        public double Salario { get; set; }
        public int Comissao { get; set; }
        

        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string TipoConta { get; set; }
        public string Conta { get; set; }

    }
}
