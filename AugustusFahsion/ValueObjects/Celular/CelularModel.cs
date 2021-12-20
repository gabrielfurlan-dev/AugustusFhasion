using System;

namespace AugustusFahsion.Model.ValueObjects.Celular
{
    public class CelularModel
    {
        private string _valor;
        public string RetornarValor { get => _valor; }
        public string RetornarValorComFormatacao { get => Convert.ToInt32(_valor).ToString(@"(000)00000-0000"); }
        public CelularModel(string valor)
        {
            _valor = valor;
        }

        public override string ToString()
        {
            return _valor;
        }

        public static implicit operator CelularModel(string valor) => new CelularModel(valor);

    }
}
