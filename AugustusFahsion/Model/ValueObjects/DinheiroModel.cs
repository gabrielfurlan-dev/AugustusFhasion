namespace AugustusFahsion.Model.ValueObjects
{
    public class DinheiroModel
    {
        private decimal _valor;

        public DinheiroModel(decimal valor) 
        {
            _valor = valor;
        }

        public decimal RetornarValor
        {
            get => _valor;
        }
        public string ValorFormatado { get => RetornarValor.ToString("c"); }

        public override string ToString()
        {
            return _valor.ToString("C");
        }

        public static implicit operator DinheiroModel(decimal valor) => new DinheiroModel(valor);
    }
}
