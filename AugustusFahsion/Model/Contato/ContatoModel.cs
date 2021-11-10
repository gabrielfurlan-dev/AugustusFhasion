using AugustusFahsion.Model.ValueObjects.Celular;
using AugustusFahsion.Model.ValueObjects.Telefone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustusFahsion.Model.Contato
{
    public class ContatoModel
    {
        public int IdContato { get; set; }
        public int IdPessoa { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Telefone: {Telefone} Celular: {Celular}, Email: {Email}";
        }
    }
}
