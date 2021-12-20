using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustusFahsion.Model.ValueObjects.Cep
{
    public class CepModel
    {
        private string _valor;

        public string RetornarValor { get => _valor; }
        public string RetornarComFormatacao { get => Convert.ToInt64(_valor).ToString(@"00000-000"); }
    
        public CepModel(string valor)
        {
            _valor = valor;
        }
        public override string ToString()
        {
            return _valor;
        }

        public static implicit operator CepModel(string valor) => new CepModel(valor);
    }

}
