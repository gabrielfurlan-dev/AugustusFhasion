using AugustusFahsion.Model;
using AugustusFahsion.Model.Contato;
using AugustusFahsion.Model.Enderecos;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AugustusFahsion.DAO
{
    public class ClienteDAO
    {
        public static void CadastrarCliente(ClienteModel cliente)
        {
<<<<<<< HEAD
            const string insertPessoa = @"insert into Pessoa output inserted.IdPessoa values (@Nome, @Sobrenome, @Sexo, @DataNascimento, @Cpf)";
            const string insertCliente = @"insert into Cliente (IdPessoa, ValorLimiteAPrazo) values (@IdPessoa, @ValorLimiteAPrazo)";
            const string insertEndereco = @"insert into Endereco (IdPessoa, Cep, Logradouro, Cidade, Uf, Complemento, Bairro, NumeroEndereco) " +
                "values (@IdPessoa, @Cep, @Logradouro, @Cidade, @Uf, @Complemento, @Bairro, @NumeroEndereco)";
            const string insertContato = @"insert into Contato (IdPessoa, Telefone, Celular, Email) values (@IdPessoa, @Telefone, @Celular, @Email)";
            
=======
>>>>>>> parent of 0fbe93f (Adicionado funcionalidade de busca personalizada)
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
<<<<<<< HEAD
                    int id = conexao.ExecuteScalar<int>(insertPessoa, cliente, transacao);
                    cliente.IdPessoa = id;
                    cliente.Endereco.IdPessoa = id;
                    cliente.Contato.IdPessoa = id;

                    conexao.Execute(insertCliente, cliente, transacao);
                    conexao.Execute(insertEndereco, cliente.Endereco, transacao);
                    conexao.Execute(insertContato, cliente.Contato, transacao);
                    transacao.Commit();
=======
                    conexao.Open();
                    var query = @"insert into Cliente values(@Nome, @Sobrenome, @Sexo, @DataNascimento, @ValorLimiteAPrazo, 
                    @Cep, @Logradouro, @Cidade, @Uf, @Complemento, @Bairro, @NumeroEndereco, @Telefone, @Celular, @Email, @Cpf)";
                    conexao.Query<ClienteModel>(query, cliente);
>>>>>>> parent of 0fbe93f (Adicionado funcionalidade de busca personalizada)
                }
            }
            catch (Exception ex){
                throw new Exception(ex.Message);
            }
        }
<<<<<<< HEAD
        public static List<ClienteListagemModel> ListarClientes()
        {
            const string listarPessoa = @"select p.IdPessoa, p.Nome, p.Sobrenome, p.IdPessoa, e.Cep, 
                e.Logradouro, e.Cidade, e.Uf, e.Complemento, e.Bairro, e.NumeroEndereco, p.IdPessoa, 
                cn.Telefone, cn.Celular, cn.Email
                from Pessoa p
                inner join Cliente c on p.IdPessoa = c.IdPessoa
                inner join Endereco e on p.IdPessoa = e.IdPessoa
                inner join Contato cn on p.IdPessoa = cn.IdPessoa";
=======

        public static List<ClienteListagem> ListarClientes()
        {
>>>>>>> parent of 0fbe93f (Adicionado funcionalidade de busca personalizada)
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
<<<<<<< HEAD
                    var resultado = conexao.Query<ClienteListagemModel, EnderecoModel, ContatoModel, ClienteListagemModel>(listarPessoa,
                        (clienteListagem, endereco, contato) => MapearClienteListagem(clienteListagem, endereco, contato),
                        splitOn:"IdPessoa"
                        ).AsList();
                    return resultado;
=======
                    conexao.Open();
                    var query = @"select Id, Nome, Sobrenome, Email, Celular from Cliente";
                    return conexao.Query<ClienteListagem>(query).AsList();
>>>>>>> parent of 0fbe93f (Adicionado funcionalidade de busca personalizada)
                }
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }

        public static bool ValidaId(int id)
        {
            try { 
            using (var conexao = new SqlConexao().Connection())
            {
<<<<<<< HEAD
                throw new Exception(ex.Message);
            }
        }
        public static ClienteModel Buscar(int id)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    var query = @"select p.IdPessoa, p.Nome, p.Sobrenome, p.Sexo, p.DataNascimento, p.Cpf, p.IdPessoa,
                    c.ValorLimiteAPrazo, p.IdPessoa,
                    e.Cep, e.Logradouro, e.Cidade, e.Uf, e.Complemento, e.Bairro, e.NumeroEndereco, p.IdPessoa,
                    cn.Telefone, cn.Celular, cn.Email
                    from Pessoa p
                    inner join Cliente c on p.IdPessoa = c.IdPessoa
                    inner join Endereco e on p.IdPessoa = e.IdPessoa
                    inner join Contato cn on p.IdPessoa = cn.IdPessoa
                    where p.IdPessoa = @IdPessoa;";

                    return conexao.Query<ClienteModel, EnderecoModel, ContatoModel, ClienteModel>
                        (query, (clienteModel, enderecoModel, contatoModel) =>
                        MapearClienteAlterar(clienteModel, enderecoModel, contatoModel), new { IdPessoa = id }, splitOn: "IdPessoa").FirstOrDefault();
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static List<ClienteListagemModel> BuscarClientePorNome(string nome)
        {
            const string listarPessoa = @"select p.IdPessoa, p.Nome, p.Sobrenome, p.IdPessoa, c.IdCliente, p.IdPessoa,
                e.Cep, e.Logradouro, e.Cidade, e.Uf, e.Complemento, e.Bairro, e.NumeroEndereco, p.IdPessoa,
                cn.Telefone, cn.Celular, cn.Email
                from Pessoa p
                inner join Cliente c on p.IdPessoa = c.IdPessoa
                inner join Endereco e on p.IdPessoa = e.IdPessoa
                inner join Contato cn on p.IdPessoa = cn.IdPessoa
                where p.Nome like @nome + '%'";
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    return conexao.Query<ClienteListagemModel, EnderecoModel, ContatoModel, ClienteListagemModel>(listarPessoa,
                        (clienteListagem, endereco, contato) => MapearClienteListagem(clienteListagem, endereco, contato),
                        new {nome }, splitOn: "IdPessoa").AsList();
                }
=======
                conexao.Open();
                var validaId = conexao.Query(@"SELECT Id FROM Cliente WHERE Id=@id", new { Id = id }).ToList();

                if (validaId.Count != 0)
                    return true;
                else
                    return false;
>>>>>>> parent of 0fbe93f (Adicionado funcionalidade de busca personalizada)
            }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

<<<<<<< HEAD
        public static List<ClienteListagemModel> BuscarClientePorId(int id)
        {
            const string listarPessoa = @"select p.IdPessoa, p.Nome, p.Sobrenome, e.Cep, 
                e.Logradouro, e.Cidade, e.Uf, e.Complemento, e.Bairro, e.NumeroEndereco, cn.Telefone, cn.Celular, cn.Email
                from Pessoa p
                inner join Cliente c on p.IdPessoa = c.IdPessoa
                inner join Endereco e on p.IdPessoa = e.IdPessoa
                inner join Cliente c on p.IdPessoa = c.IdPessoa 
                where p.IdPessoa = @id";
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    return conexao.Query<ClienteListagemModel, EnderecoModel, ContatoModel, ClienteListagemModel>(listarPessoa,
                        (clienteListagem, endereco, contato) => MapearClienteListagem(clienteListagem, endereco, contato),
                        new { id }, splitOn: "IdPessoa").AsList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
=======
        public static ClienteModel Buscar(IDbConnection conexao, int id)
        {
            conexao.Open();
            var query = @"select * from Cliente where Id=@id";
            var parametros = new DynamicParameters();
            parametros.Add("@id", id, System.Data.DbType.Int32);
            var resultado = conexao.QueryFirstOrDefault<ClienteModel>(query, parametros);
            return resultado;
>>>>>>> parent of 0fbe93f (Adicionado funcionalidade de busca personalizada)
        }
        public static void AlterarCliente(ClienteModel cliente)
        {
            try
            {
<<<<<<< HEAD
                const string updatePessoa = @"update Pessoa set Nome = @Nome, Sobrenome = @Sobrenome, Sexo = @Sexo, 
                DataNascimento = @DataNascimento, Cpf = @Cpf where IdPessoa = @IdPessoa";

                const string updateCliente = @"update Cliente set ValorLimiteAPrazo = @ValorLimiteAPrazo where IdPessoa = @IdPessoa";

                const string updateEndereco = @"update Endereco set Cep = @Cep, Logradouro = @Logradouro, Cidade = @Cidade, 
                Uf = @Uf, Complemento = @Complemento, Bairro = @Bairro, NumeroEndereco = @NumeroEndereco where IdPessoa = @IdPessoa";

                const string updateContato = @"update Contato set Telefone = @Telefone, Celular = @Celular, Email = @Email where IdPessoa = @IdPessoa";


                using var conexao = new SqlConexao().Connection();
                conexao.Open();
                using (var transacao = conexao.BeginTransaction())
                {
                    conexao.Execute(updatePessoa, cliente, transacao);
                    conexao.Execute(updateCliente, cliente, transacao);
                    conexao.Execute(updateEndereco, cliente.Endereco, transacao);
                    conexao.Execute(updateContato, cliente.Contato, transacao);
                    transacao.Commit();
=======
                using (var conexao = new SqlConexao().Connection())
                {

                    conexao.Open();
                    var id = cliente.Id;
                    var query = @"update Cliente set Nome = @Nome, Sobrenome = @Sobrenome, Sexo = @Sexo, DataNascimento = @DataNascimento, ValorLimiteAPrazo = @ValorLimiteAPrazo, 
                Cep = @Cep, Logradouro = @Logradouro, Cidade = @Cidade, Uf = @Uf, Complemento = @Complemento, Bairro = @Bairro, NumeroEndereco = @NumeroEndereco, Telefone = @Telefone, Celular = @Celular, Email = @Email, Cpf =  @Cpf where Id=@id ";
                    conexao.Query<ClienteModel>(query, cliente);
>>>>>>> parent of 0fbe93f (Adicionado funcionalidade de busca personalizada)
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void ExcluirCliente(ClienteModel cliente)
        {
            var idPessoa = cliente.IdPessoa;
            string deleteContato = @"delete from Contato where IdPessoa =" + idPessoa;
            string deleteEndereco = @"delete from Endereco where IdPessoa = " + idPessoa;
            string deleteCliente = @"delete from Cliente where IdPessoa = " + idPessoa;
            string deletePessoa = @"delete from Pessoa where IdPessoa = " + idPessoa;
            try
            {
                using var conexao = new SqlConexao().Connection();
                conexao.Open();
                using (var transacao = conexao.BeginTransaction())
                {
<<<<<<< HEAD
                    conexao.Execute(deleteContato, idPessoa, transacao);
                    conexao.Execute(deleteEndereco, idPessoa, transacao);
                    conexao.Execute(deleteCliente, idPessoa, transacao);
                    conexao.Execute(deletePessoa, idPessoa, transacao);
                    transacao.Commit();
=======
                    conexao.Open();
                    var id = cliente.Id;
                    conexao.Query(@"delete from Cliente where Id=" + id);
>>>>>>> parent of 0fbe93f (Adicionado funcionalidade de busca personalizada)
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static ClienteListagemModel MapearClienteListagem(ClienteListagemModel clienteListagem,
            EnderecoModel endereco, ContatoModel contato)
        {
            clienteListagem.Contato = contato;
            clienteListagem.Endereco = endereco;
            return clienteListagem;
        }

        public static ClienteModel MapearClienteAlterar(ClienteModel clienteModel,
            EnderecoModel endereco, ContatoModel contato)
        {
            clienteModel.Contato = contato;
            clienteModel.Endereco = endereco;
            return clienteModel;
        }
    }
}
