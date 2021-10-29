using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustusFahsion.Model
{
    public class ColaboradorListagem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public decimal Salario { get; set; }
        public int Comissao { get; set; }
    }
}
