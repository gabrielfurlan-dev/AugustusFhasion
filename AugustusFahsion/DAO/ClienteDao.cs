using AugustusFahsion.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AugustusFahsion.DAO
{
    public class ClienteDao
    {
        public static void CadastrarCliente(ClienteModel cliente)
        {
            const string insertPessoa = "insert into Pessoa output inserted.IdPessoa values (@Nome, @Sobrenome, @Sexo, @DataNascimento, " +
                "@Cep, @Logradouro, @Cidade, @Uf, @Complemento, @Bairro, @NumeroEndereco, @Telefone, @Celular, @Email, @Cpf)";
            const string insertCliente = "insert into Cliente (IdPessoa, ValorLimiteAPrazo) values (@IdPessoa, @ValorLimiteAPrazo)";
            try
            {
                using var conexao = new SqlConexao().Connection();
                conexao.Open();
                using (var transacao = conexao.BeginTransaction())
                {
                    int id = conexao.ExecuteScalar<int>(insertPessoa, cliente, transacao);

                    cliente.IdPessoa = id;
                    conexao.Execute(insertCliente, cliente, transacao);
                    transacao.Commit();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static List<ClienteListagem> ListarClientes()
        {
            const string listarPessoa = @"select c.IdCliente, p.Nome, p.Sobrenome, p.Email, p.Celular
                from Pessoa p
                inner join Cliente c on p.IdPessoa = c.IdPessoa;";
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    var resultado = conexao.Query<ClienteListagem>(listarPessoa).AsList();
                    return resultado;
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
                    conexao.Open();
                    var validaId = conexao.Query(@"SELECT IdPessoa FROM Cliente WHERE IdPessoa=@IdPessoa", new { IdPessoa = id }).ToList();

                    if (validaId.Count != 0)
                        return true;
                    else
                        return false;
                }
            }catch(Exception ex)
            {
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
                    var query = @"select c.*, p.*
                    from Pessoa p
                    inner join Cliente c on p.IdPessoa = c.IdPessoa where IdCliente = @IdCliente;";
                    var parametros = new DynamicParameters();
                    parametros.Add("@IdCliente", id, System.Data.DbType.Int32);
                    var resultado = conexao.QueryFirstOrDefault<ClienteModel>(query, parametros);
                    return resultado;
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<ClienteListagem> BuscarClientePorNome(string nome)
        {
            const string listarPessoa = @"select c.IdCliente, p.Nome, p.Sobrenome, p.Email, p.Celular
                from Pessoa p
                inner join Cliente c on p.IdPessoa = c.IdPessoa where p.Nome like @nome + '%'";
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    return conexao.Query<ClienteListagem>(listarPessoa, new { nome }).AsList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<ClienteListagem> BuscarClientePorId(int id)
        {
            const string listarPessoa = @"select c.IdCliente, p.Nome, p.Sobrenome, p.Email, p.Celular
                from Pessoa p
                inner join Cliente c on p.IdPessoa = c.IdPessoa where p.IdPessoa = @id";
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    return conexao.Query<ClienteListagem>(listarPessoa, new { id }).AsList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void AlterarCliente(ClienteModel cliente)
        {
            try
            {
                const string updatePessoa = "update Pessoa set Nome = @Nome, Sobrenome = @Sobrenome, Sexo = @Sexo, DataNascimento = @DataNascimento, " +
                    "Cep = @Cep, Logradouro = @Logradouro, Cidade = @Cidade, Uf = @Uf, Complemento = @Complemento, Bairro = @Bairro, NumeroEndereco = @NumeroEndereco, " +
                    "Telefone = @Telefone, Celular = @Celular, Email = @Email, Cpf = @Cpf where IdPessoa = @IdPessoa;";

                const string updateCliente = "update Cliente set ValorLimiteAPrazo = @ValorLimiteAPrazo where IdPessoa = @IdPessoa";


                using var conexao = new SqlConexao().Connection();
                conexao.Open();
                using (var transacao = conexao.BeginTransaction())
                {
                    conexao.Execute(updatePessoa, cliente, transacao);
                    conexao.Execute(updateCliente, cliente, transacao);
                    transacao.Commit();
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void ExcluirCliente(ClienteModel cliente)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    var id = cliente.IdPessoa;
                    conexao.Query(@"delete from Cliente where Id=" + id);
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
