namespace AugustusFahsion.Model
{
    public class ClienteModel : Pessoa
    {
        public int IdCliente { get; set; }
        public int IdPessoa { get; set; }
        public double ValorLimiteAPrazo { get; set; }
    }
}