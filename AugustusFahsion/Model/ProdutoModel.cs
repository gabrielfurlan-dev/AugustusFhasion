using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustusFahsion.Model
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public double PrecoCusto { get; set; }
        public double PrecoVenda { get; set; }
        public double precoPromocao { get; set; }
        public string CodigoBarras { get; set; }
        public DateTime DataValidade { get; set; }
    }
}
