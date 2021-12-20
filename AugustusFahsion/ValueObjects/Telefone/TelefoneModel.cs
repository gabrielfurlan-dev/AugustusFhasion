using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustusFahsion.Model.ValueObjects.Telefone
{
    public class TelefoneModel
    {
            private string _valor;
            public string RetornarValor { get => _valor; }
            public string RetornarValorComFormatacao { get => Convert.ToInt32(_valor).ToString(@"0000-0000"); }
            public TelefoneModel(string valor)
            {
                _valor = valor;
            }

            public override string ToString()
            {
                return _valor;
            }

            public static implicit operator TelefoneModel(string valor) => new TelefoneModel(valor);

    }
}
