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
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    var query = @"insert into Cliente values(@Nome, @Sobrenome, @Sexo, @DataNascimento, @ValorLimiteAPrazo, 
                    @Cep, @Logradouro, @Cidade, @Uf, @Complemento, @Bairro, @NumeroEndereco, @Telefone, @Celular, @Email, @Cpf)";
                    conexao.Query<ClienteModel>(query, cliente);
                }
            }
            catch (Exception ex){
                throw new Exception(ex.Message);
            }
        }

        public static List<ClienteListagem> ListarClientes()
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    var query = @"select Id, Nome, Sobrenome, Email, Celular from Cliente";
                    return conexao.Query<ClienteListagem>(query).AsList();
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
                var validaId = conexao.Query(@"SELECT Id FROM Cliente WHERE Id=@id", new { Id = id }).ToList();

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

        public static ClienteModel Buscar(IDbConnection conexao, int id)
        {
            conexao.Open();
            var query = @"select * from Cliente where Id=@id";
            var parametros = new DynamicParameters();
            parametros.Add("@id", id, System.Data.DbType.Int32);
            var resultado = conexao.QueryFirstOrDefault<ClienteModel>(query, parametros);
            return resultado;
        }

        public static void AlterarCliente(ClienteModel cliente)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {

                    conexao.Open();
                    var id = cliente.Id;
                    var query = @"update Cliente set Nome = @Nome, Sobrenome = @Sobrenome, Sexo = @Sexo, DataNascimento = @DataNascimento, ValorLimiteAPrazo = @ValorLimiteAPrazo, 
                Cep = @Cep, Logradouro = @Logradouro, Cidade = @Cidade, Uf = @Uf, Complemento = @Complemento, Bairro = @Bairro, NumeroEndereco = @NumeroEndereco, Telefone = @Telefone, Celular = @Celular, Email = @Email, Cpf =  @Cpf where Id=@id ";
                    conexao.Query<ClienteModel>(query, cliente);
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
                    var id = cliente.Id;
                    conexao.Query(@"delete from Cliente where Id=" + id);
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
