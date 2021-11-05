using AugustusFahsion.Model;
using AugustusFahsion.Model.ContasBancaria;
using AugustusFahsion.Model.Contato;
using AugustusFahsion.Model.Enderecos;
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
<<<<<<< HEAD
            const string insertPessoa = @"insert into Pessoa output inserted.IdPessoa values (@Nome, @Sobrenome, @Sexo, @DataNascimento, @Cpf)";
            const string insertColaborador = @"insert into Colaborador (IdPessoa, Salario, Comissao)" +
                " values (@IdPessoa, @Salario, @Comissao)";
            const string insertEndereco = @"insert into Endereco (IdPessoa, Cep, Logradouro, Cidade, Uf, Complemento, Bairro, NumeroEndereco) " +
                "values (@IdPessoa, @Cep, @Logradouro, @Cidade, @Uf, @Complemento, @Bairro, @NumeroEndereco)";
            const string insertContato = @"insert into Contato (IdPessoa, Telefone, Celular, Email) values (@IdPessoa, @Telefone, @Celular, @Email)";
            const string insertContaBancaria = @"insert into ContaBancaria (IdPessoa, Banco, Agencia, Conta, TipoConta) values (@IdPessoa, @Banco, @Agencia, @Conta, @TipoConta)";

=======
>>>>>>> parent of 0fbe93f (Adicionado funcionalidade de busca personalizada)
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
<<<<<<< HEAD
                    int id = conexao.ExecuteScalar<int>(insertPessoa, colaborador, transacao);
                    colaborador.IdPessoa = id;
                    colaborador.Endereco.IdPessoa = id;
                    colaborador.Contato.IdPessoa = id;
                    colaborador.ContaBancaria.IdPessoa = id;

                    conexao.Execute(insertColaborador, colaborador, transacao);
                    conexao.Execute(insertEndereco, colaborador.Endereco, transacao);
                    conexao.Execute(insertContato, colaborador.Contato, transacao);
                    conexao.Execute(insertContaBancaria, colaborador.ContaBancaria, transacao);
                    transacao.Commit();
=======
                    var query = @"insert into Colaborador values(@Nome, @Sobrenome, @Sexo, @DataNascimento, @Salario, @Comissao, 
            @Cep, @Logradouro, @Cidade, @Uf, @Complemento, @Bairro, @NumeroEndereco, @Telefone, @Celular, @Email, @Cpf, @Banco, @Agencia, @Conta, @TipoConta)";
                    conexao.Query<ColaboradorModel>(query, colaborador);
>>>>>>> parent of 0fbe93f (Adicionado funcionalidade de busca personalizada)
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static List<ColaboradorListagemModel> ListarColaboradores()
        {
                const string listarColaboradores = @"select p.IdPessoa, p.Nome, p.Sobrenome, p.Salario, p.Comissao, p.IdPessoa, 
                    e.Cep, e.Logradouro, e.Cidade, e.Uf, e.Complemento, e.Bairro, e.NumeroEndereco, p.IdPessoa, 
                    cn.Telefone, cn.Celular, cn.Email
                    from Pessoa p
                    inner join Cliente c on p.IdPessoa = c.IdPessoa
                    inner join Endereco e on p.IdPessoa = e.IdPessoa
                    inner join Contato cn on p.IdPessoa = cn.IdPessoa";
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
<<<<<<< HEAD
                    var resultado = conexao.Query<ColaboradorListagemModel, EnderecoModel, ContatoModel, ColaboradorListagemModel>(listarColaboradores,
                        (colaboradorListagem, enderecoModel, contatoModel) => MapearColaboradorListagem(colaboradorListagem, enderecoModel, contatoModel),
                        splitOn: "IdPessoa").AsList();
                    return resultado; 
=======
                    var query = @"select Id, Nome, Sobrenome, Celular, Email, Salario, Comissao from Colaborador";
                    return conexao.Query<ColaboradorListagem>(query).AsList();
>>>>>>> parent of 0fbe93f (Adicionado funcionalidade de busca personalizada)
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
<<<<<<< HEAD

=======
>>>>>>> parent of 0fbe93f (Adicionado funcionalidade de busca personalizada)
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
<<<<<<< HEAD
                    conexao.Open();
                    var query = @"select p.IdPessoa, p.Nome, p.Sobrenome, p.Sexo, p.DataNascimento, p.Cpf, p.IdPessoa,
                    c.Salario, c.Comissao, p.IdPessoa,
                    e.Cep, e.Logradouro, e.Cidade, e.Uf, e.Complemento, e.Bairro, e.NumeroEndereco, p.IdPessoa,
                    cn.Telefone, cn.Celular, cn.Email, p.IdPessoa,
                    cb.Banco, cb.Agencia, cb.Conta, cb.TipoConta
                    from Pessoa p
                    inner join Colaborador c on p.IdPessoa = c.IdPessoa
                    inner join Endereco e on p.IdPessoa = e.IdPessoa
                    inner join Contato cn on p.IdPessoa = cn.IdPessoa
                    inner join ContaBancaria cb on p.IdPessoa = cb.IdPessoa
                    where p.IdPessoa = @IdPessoa;";

                    return conexao.Query<ColaboradorModel, EnderecoModel, ContatoModel, ContaBancariaModel, ColaboradorModel>(query,
                        (colaboradorModel, endereco, contato, contaBancaria) => MapearColaboradorModel(colaboradorModel, endereco, contato, contaBancaria),
                        new { IdPessoa = id }, splitOn: "IdPessoa").FirstOrDefault();
=======
                    var query = @"select * from Colaborador where Id=@id";
                    var parametros = new DynamicParameters();
                    parametros.Add("@id", id, System.Data.DbType.Int32);
                    var resultado = conexao.QueryFirstOrDefault<ColaboradorModel>(query, parametros);
                    return resultado;
>>>>>>> parent of 0fbe93f (Adicionado funcionalidade de busca personalizada)
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
<<<<<<< HEAD
        public static List<ColaboradorListagemModel> BuscarColaboradoresPorNome(string nome)
        {
            const string query = @"select p.IdPessoa, p.Nome, p.Sobrenome, co.Salario, co.Comissao, p.IdPessoa, 
                e.Cep, e.Logradouro, e.Cidade, e.Uf, e.Complemento, e.Bairro, e.NumeroEndereco, p.IdPessoa, 
                cn.Telefone, cn.Celular, cn.Email
                from Pessoa p
                inner join Colaborador co on p.IdPessoa = co.IdPessoa
                inner join Endereco e on p.IdPessoa = e.IdPessoa
                inner join Contato cn on p.IdPessoa = cn.IdPessoa
                where p.Nome like @nome + '%'";
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    return conexao.Query<ColaboradorListagemModel, EnderecoModel, ContatoModel, ColaboradorListagemModel>(query,
                        (colaboradorListagem, endereco, contato) => MapearColaboradorListagem(colaboradorListagem, endereco, contato),
                        new { nome }, splitOn:"IdPessoa").AsList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static List<ColaboradorListagemModel> BuscarColaboradoresPorId(int id)
        {
            const string  query = @"select p.IdPessoa, p.Nome, p.Sobrenome, p.Salario, p.Comissao, p.IdPessoa, 
                e.Cep, e.Logradouro, e.Cidade, e.Uf, e.Complemento, e.Bairro, e.NumeroEndereco, p.IdPessoa, 
                cn.Telefone, cn.Celular, cn.Email
                from Pessoa p
                inner join Cliente c on p.IdPessoa = c.IdPessoa
                inner join Endereco e on p.IdPessoa = e.IdPessoa
                inner join Contato cn on p.IdPessoa = cn.IdPessoa
                where p.IdPessoa = @id";
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {

                    return conexao.Query<ColaboradorListagemModel, EnderecoModel, ContatoModel, ColaboradorListagemModel>(query,
                        (colaboradorListagem, endereco, contato) => MapearColaboradorListagem(colaboradorListagem, endereco, contato),
                        new { id }, splitOn: "IdPessoa").AsList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
=======
>>>>>>> parent of 0fbe93f (Adicionado funcionalidade de busca personalizada)

        public static void AlterarColaborador(ColaboradorModel colaborador)
        {
            try
            {
<<<<<<< HEAD
                const string updatePessoa = @"update Pessoa set Nome = @Nome, Sobrenome = @Sobrenome, Sexo = @Sexo, 
                DataNascimento = @DataNascimento, Cpf =  @Cpf where IdPessoa=@IdPessoa";
                const string updateColaborador = @"update Colaborador set Salario = @Salario, Comissao = @Comissao where IdColaborador=@IdColaborador";
                const string updateEndereco = @"update Endereco set Cep = @Cep, Logradouro = @Logradouro, Cidade = @Cidade, 
                Uf = @Uf, Complemento = @Complemento, Bairro = @Bairro, NumeroEndereco = @NumeroEndereco where IdPessoa = @IdPessoa";
                const string updateContato = @"update Contato set Telefone = @Telefone, Celular = @Celular, Email = @Email where IdPessoa = @IdPessoa";
                const string updateContaBancaria = @"update ContaBancaria set Banco = @Banco, Agencia = @Agencia, Conta = @Conta, TipoConta = @TipoConta
                where IdPessoa = @IdPessoa";

                using var conexao = new SqlConexao().Connection();
                conexao.Open();
                using (var transacao = conexao.BeginTransaction())
                
                {
                    conexao.Execute(updatePessoa, colaborador, transacao);
                    conexao.Execute(updateColaborador, colaborador, transacao);
                    conexao.Execute(updateEndereco, colaborador.Endereco, transacao);
                    conexao.Execute(updateContato, colaborador.Contato, transacao);
                    conexao.Execute(updateContaBancaria, colaborador.ContaBancaria, transacao);
                    transacao.Commit();
=======
                using (var conexao = new SqlConexao().Connection())
                {
                    var id = colaborador.Id;
                    var query = @"update Colaborador set Nome = @Nome, Sobrenome = @Sobrenome, Sexo = @Sexo, DataNascimento = @DataNascimento, Salario = @Salario, Comissao = @Comissao,
                    Cep = @Cep, Logradouro = @Logradouro, Cidade = @Cidade, Uf = @Uf, Complemento = @Complemento, Bairro = @Bairro, NumeroEndereco = @NumeroEndereco, Telefone = @Telefone, Celular = @Celular, Email = @Email, Cpf =  @Cpf, Banco = @Banco, Agencia = @Agencia, Conta = @Conta, TipoConta = @TipoConta where Id=@id ";
                    conexao.Query<ColaboradorModel>(query, colaborador);
>>>>>>> parent of 0fbe93f (Adicionado funcionalidade de busca personalizada)
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);           
            }
        }

        public static void ExcluirColaborador(ColaboradorModel colaborador)
        {
            var idPessoa = colaborador.IdPessoa;
            string deleteContaBancaria = @"delete from ContaBancaria where IdPessoa =" + idPessoa;
            string deleteContato = @"delete from Contato where IdPessoa =" + idPessoa;
            string deleteEndereco = @"delete from Endereco where IdPessoa = " + idPessoa;
            string deleteColaborador = @"delete from Colaborador where IdPessoa = " + idPessoa;
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
                    conexao.Execute(deleteColaborador, idPessoa, transacao);
                    conexao.Execute(deletePessoa, idPessoa, transacao);
                    transacao.Commit();
=======
                    var id = colaborador.Id;
                    conexao.Query(@"delete from Colaborador where Id=" + id);
>>>>>>> parent of 0fbe93f (Adicionado funcionalidade de busca personalizada)
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static ColaboradorListagemModel MapearColaboradorListagem(ColaboradorListagemModel colaboradorListagem,
            EnderecoModel endereco, ContatoModel contato)
        {
            colaboradorListagem.Contato = contato;
            colaboradorListagem.Endereco = endereco;
            return colaboradorListagem;
        }

        public static ColaboradorModel MapearColaboradorModel(ColaboradorModel colaboradorModel, 
            EnderecoModel endereco, ContatoModel contato, ContaBancariaModel contaBancaria)
        {
            colaboradorModel.ContaBancaria = contaBancaria;
            colaboradorModel.Contato = contato;
            colaboradorModel.Endereco = endereco;
            return colaboradorModel;
        }

    }
}
