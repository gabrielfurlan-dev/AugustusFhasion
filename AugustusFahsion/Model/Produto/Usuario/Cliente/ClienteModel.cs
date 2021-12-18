using AugustusFahsion.Model.ValueObjects;
namespace AugustusFahsion.Model
{
    public class ClienteModel : Pessoa
    {
        public int IdCliente { get; set; }
        public int IdPessoa { get; set; }   
        public DinheiroModel ValorLimiteAPrazo { get; set; }
        public string Condicao { get; set; }

        public DinheiroModel ValorLimiteGasto { get; set; }
    }
}
