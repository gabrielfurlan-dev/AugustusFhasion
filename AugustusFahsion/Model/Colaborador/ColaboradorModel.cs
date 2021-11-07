using AugustusFahsion.Model.ContasBancaria;

namespace AugustusFahsion.Model
{
    public class ColaboradorModel : Pessoa
    {

        public int IdColaborador { get; set; }
        public int IdPessoa { get; set; }

        public double Salario { get; set; }
        public int Comissao { get; set; }

        public ContaBancariaModel ContaBancaria { get; set; }

        public ColaboradorModel()
        {
            ContaBancaria = new ContaBancariaModel();
        }
    }
}