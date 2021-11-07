using AugustusFahsion.Model.Contato;
using AugustusFahsion.Model.Enderecos;

namespace AugustusFahsion.Model
{
    public class ClienteListagemModel
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public EnderecoModel Endereco { get; set; }
        public ContatoModel Contato { get; set; }

        public ClienteListagemModel()
        {
            Endereco = new EnderecoModel();
            Contato = new ContatoModel();
        }
    }

}