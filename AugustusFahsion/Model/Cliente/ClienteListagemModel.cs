using AugustusFahsion.Model.Contato;
using AugustusFahsion.Model.Enderecos;
using AugustusFahsion.Model.ValueObjects;

namespace AugustusFahsion.Model
{
    public class ClienteListagemModel
    {
        public int IdPessoa { get; set; }
        public NomeCompletoModel NomeCompleto { get; set; }
        public EnderecoModel Endereco { get; set; }
        public ContatoModel Contato { get; set; }

        public ClienteListagemModel()
        {
            Endereco = new EnderecoModel();
            Contato = new ContatoModel();
            NomeCompleto = new NomeCompletoModel();
        }
    }
}
