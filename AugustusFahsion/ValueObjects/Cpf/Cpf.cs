using System;

namespace AugustusFahsion.Model.ValueObjects
{
    public class CpfModel
    {
        private string _valor;

        public string RetornarValor { get => _valor; }
        public string RetornarComFormatacao { get => Convert.ToInt64(_valor).ToString(@"000.000.000-00"); }

        public CpfModel(string valor)
        {
            _valor = valor;
        }
        public override string ToString()
        {
            return _valor;
        }

        public static implicit operator CpfModel(string valor) => new CpfModel(valor);

    }
}