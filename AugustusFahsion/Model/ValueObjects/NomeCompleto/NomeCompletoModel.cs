using System;

namespace AugustusFahsion.Model.ValueObjects
{
    public class NomeCompletoModel
    {
        //private string _valor;

        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public NomeCompletoModel(string nome, string sobrenome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new Exception("Nome é inválido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(sobrenome))
            {
                throw new Exception("Sobrenome é inválido");
                return;
            }

            Nome = nome;
            Sobrenome = sobrenome;

        }
        public NomeCompletoModel()
        {
            
        }
        public override string ToString()
        {
            return $"{Nome} {Sobrenome}";
        }
    }
}
