using AugustusFahsion.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AugustusFahsion.DAO
{
    class ColaboradorDAO
    {
        public static void CadastrarColaborador(ColaboradorModel colaborador)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    var query = @"insert into Colaborador values(@Nome, @Sobrenome, @Sexo, @DataNascimento, @Salario, @Comissao, 
            @Cep, @Logradouro, @Cidade, @Uf, @Complemento, @Bairro, @NumeroEndereco, @Telefone, @Celular, @Email, @Cpf, @Banco, @Agencia, @Conta, @TipoConta)";
                    conexao.Query<ColaboradorModel>(query, colaborador);
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static List<ColaboradorListagem> ListarColaboradores()
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    var query = @"select Id, Nome, Sobrenome, Celular, Email, Salario, Comissao from Colaborador";
                    return conexao.Query<ColaboradorListagem>(query).AsList();
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static bool ValidaId(int id)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    var validaId = conexao.Query(@"SELECT Id FROM Colaborador WHERE Id=@id", new { Id = id }).ToList();
                    
                    if (validaId.Count != 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }
        public static ColaboradorModel Buscar(int id)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    var query = @"select * from Colaborador where Id=@id";
                    var parametros = new DynamicParameters();
                    parametros.Add("@id", id, System.Data.DbType.Int32);
                    var resultado = conexao.QueryFirstOrDefault<ColaboradorModel>(query, parametros);
                    return resultado;
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void AlterarColaborador(ColaboradorModel colaborador)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    var id = colaborador.Id;
                    var query = @"update Colaborador set Nome = @Nome, Sobrenome = @Sobrenome, Sexo = @Sexo, DataNascimento = @DataNascimento, Salario = @Salario, Comissao = @Comissao,
                    Cep = @Cep, Logradouro = @Logradouro, Cidade = @Cidade, Uf = @Uf, Complemento = @Complemento, Bairro = @Bairro, NumeroEndereco = @NumeroEndereco, Telefone = @Telefone, Celular = @Celular, Email = @Email, Cpf =  @Cpf, Banco = @Banco, Agencia = @Agencia, Conta = @Conta, TipoConta = @TipoConta where Id=@id ";
                    conexao.Query<ColaboradorModel>(query, colaborador);
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);           
            }
        }

        public static void ExcluirColaborador(ColaboradorModel colaborador)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {

                    var id = colaborador.Id;
                    conexao.Query(@"delete from Colaborador where Id=" + id);
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
