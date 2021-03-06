using AugustusFahsion.Model.ContasBancaria;
using AugustusFahsion.Model.ValueObjects;

namespace AugustusFahsion.Model
{
    public class ColaboradorModel : Pessoa
    {
        public int IdPessoa { get; set; }
        public int IdColaborador { get; set; }
        public DinheiroModel Salario { get; set; }
        public int Comissao { get; set; }
        public string Condicao { get; set; }

        public ContaBancariaModel ContaBancaria { get; set; }

        public ColaboradorModel() => ContaBancaria = new ContaBancariaModel();
    }
}
