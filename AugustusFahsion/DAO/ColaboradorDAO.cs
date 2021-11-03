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
            const string insertPessoa = "insert into Pessoa output inserted.IdPessoa values (@Nome, @Sobrenome, @Sexo, @DataNascimento, " +
                "@Cep, @Logradouro, @Cidade, @Uf, @Complemento, @Bairro, @NumeroEndereco, @Telefone, @Celular, @Email, @Cpf)";
            const string insertColaborador = "insert into Colaborador (IdPessoa, Salario, Comissao, Banco, Agencia, Conta, TipoConta)" +
                " values (@IdPessoa, @Salario, @Comissao, @Banco, @Agencia, @Conta, @TipoConta)";
            try
            {
                using var conexao = new SqlConexao().Connection();
                conexao.Open();
                using (var transacao = conexao.BeginTransaction()) 
                {
                    int id = conexao.ExecuteScalar<int>(insertPessoa, colaborador, transacao);

                    colaborador.IdPessoa = id;
                    conexao.Execute(insertColaborador, colaborador, transacao);
                    transacao.Commit();
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
                    const string listarColaboradores = @"select c.IdColaborador, p.Nome, p.Sobrenome, p.Celular, p.Email, c.Salario, c.Comissao 
                    from Pessoa p
                    inner join Colaborador c on p.IdPessoa = c.IdPessoa";
                    var resultado =  conexao.Query<ColaboradorListagem>(listarColaboradores).AsList();
                    return resultado; 
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void ProcurarColaborador(string valorPesquisar)
        {
            
        }
        public static bool ValidaId(int id)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    var validaId = conexao.Query(@"SELECT IdPessoa FROM Colaborador WHERE IdPessoa=@IdPessoa", new { IdPessoa = id }).ToList();
                    
                    if (validaId.Count != 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
        public static ColaboradorModel Buscar(int id)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    var query = @"select co.*, p.*
                    from Pessoa p
                    inner join Colaborador co on p.IdPessoa = co.IdPessoa where IdColaborador = @IdColaborador;";
                    var parametros = new DynamicParameters();
                    parametros.Add("@IdColaborador", id, System.Data.DbType.Int32);
                    var resultado = conexao.QueryFirstOrDefault<ColaboradorModel>(query, parametros);
                    return resultado;
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static List<ColaboradorListagem> BuscarColaboradoresPorNome(string nome)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    var query = @"select c.IdColaborador, p.Nome, p.Sobrenome, p.Celular, p.Email, c.Salario, c.Comissao 
                    from Pessoa p 
                    inner join Colaborador c on p.IdPessoa = c.IdPessoa where p.Nome like @nome +'%'";
                    var teste = conexao.Query<ColaboradorListagem>(query, new {nome}).AsList();
                    return teste;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static List<ColaboradorListagem> BuscarColaboradoresPorId(int id)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    var query = @"select c.IdColaborador, p.Nome, p.Sobrenome, p.Celular, p.Email, c.Salario, c.Comissao
                    from Pessoa p
                    inner join Colaborador c on p.IdPessoa = c.IdPessoa
                    where p.IdPessoa = @id";
                    
                    var teste = conexao.Query<ColaboradorListagem>(query, new {id}).AsList();
                    return teste;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void AlterarColaborador(ColaboradorModel colaborador)
        {
            try
            {
                const string updatePessoa = @"update Pessoa set Nome = @Nome, Sobrenome = @Sobrenome, Sexo = @Sexo, 
                DataNascimento = @DataNascimento, Cep = @Cep, Logradouro = @Logradouro, Cidade = @Cidade,
                Uf = @Uf, Complemento = @Complemento, Bairro = @Bairro, NumeroEndereco = @NumeroEndereco,
                Telefone = @Telefone, Celular = @Celular, Email = @Email, Cpf =  @Cpf where IdPessoa=@IdPessoa";

                const string updateColaborador = @"update Colaborador set Salario = @Salario, Comissao = @Comissao, 
                Banco = @Banco, Agencia = @Agencia,Conta = @Conta, TipoConta = @TipoConta where IdColaborador=@IdColaborador";
                
                using var conexao = new SqlConexao().Connection();
                conexao.Open();
                using (var transacao = conexao.BeginTransaction())
                
                {
                    conexao.Execute(updatePessoa, colaborador, transacao);
                    conexao.Execute(updateColaborador, colaborador, transacao);
                    transacao.Commit();
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

                    var id = colaborador.IdPessoa;
                    conexao.Query(@"delete from Colaborador where Id=" + id);
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
