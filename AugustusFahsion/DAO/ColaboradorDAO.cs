using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using AugustusFahsion.Model.ContasBancaria;
using AugustusFahsion.Model.Contato;
using AugustusFahsion.Model.Enderecos;
using AugustusFahsion.Model.ValueObjects;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AugustusFahsion.DAO
{
    class ColaboradorDAO
    {
        public static void CadastrarColaborador(ColaboradorModel colaborador)
        {
            const string insertPessoa = @"insert into Pessoa output inserted.IdPessoa values (@Nome, @Sobrenome, @Sexo, @DataNascimento, @Cpf)";
            
            const string insertColaborador = @"insert into Colaborador (IdPessoa, Salario, Comissao)
                                               values (@IdPessoa, @Salario, @Comissao)";

            const string insertEndereco = @"insert into Endereco (IdPessoa, Cep, Logradouro, Cidade, Uf, Complemento, Bairro, NumeroEndereco) 
                                            values (@IdPessoa, @Cep, @Logradouro, @Cidade, @Uf, @Complemento, @Bairro, @NumeroEndereco)";
            
            const string insertContato = @"insert into Contato (IdPessoa, Telefone, Celular, Email) values (@IdPessoa, @Telefone, @Celular, @Email)";

            const string insertContaBancaria = @"insert into ContaBancaria (IdPessoa, Banco, Agencia, Conta, TipoConta) 
                                                 values (@IdPessoa, @Banco, @Agencia, @Conta, @TipoConta)";

            try
            {
                using var conexao = new SqlConexao().Connection();
                conexao.Open();
                using (var transacao = conexao.BeginTransaction())
                
                {
                    int id = conexao.ExecuteScalar<int>(insertPessoa, new
                    {
                        colaborador.NomeCompleto.Nome,
                        colaborador.NomeCompleto.Sobrenome,
                        colaborador.Sexo,
                        colaborador.DataNascimento,
                        Cpf = Metodos.RemoverMascaraDeFormatacao(colaborador.Cpf.RetornarValor)
                    }, transacao);

                    colaborador.IdPessoa = id;
                    colaborador.Endereco.IdPessoa = id;
                    colaborador.Contato.IdPessoa = id;
                    colaborador.ContaBancaria.IdPessoa = id;

                    conexao.Execute(insertColaborador, colaborador, transacao);
                    conexao.Execute(insertEndereco, new
                    {
                        colaborador.IdPessoa,
                        Cep = Metodos.RemoverMascaraDeFormatacao(colaborador.Endereco.Cep.RetornarValor),
                        colaborador.Endereco.Logradouro,
                        colaborador.Endereco.Cidade,
                        colaborador.Endereco.Uf,
                        colaborador.Endereco.Complemento,
                        colaborador.Endereco.Bairro,
                        colaborador.Endereco.NumeroEndereco
                    }, transacao);
                    conexao.Execute(insertContato, colaborador.Contato, transacao);
                    conexao.Execute(insertContaBancaria, colaborador.ContaBancaria, transacao);
                    transacao.Commit();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<ColaboradorListagemModel> ListarColaboradores()
        {
            const string listarColaboradores = @"select c.IdColaborador, p.IdPessoa,
                    p.Nome, p.Sobrenome, p.IdPessoa, 
                    e.Cep, e.Logradouro, e.Cidade, e.Uf, e.Complemento, e.Bairro, e.NumeroEndereco, p.IdPessoa, 
                    cn.Telefone, cn.Celular, cn.Email
                    from Pessoa p
                    inner join Colaborador c on p.IdPessoa = c.IdPessoa
                    inner join Endereco e on p.IdPessoa = e.IdPessoa
                    inner join Contato cn on p.IdPessoa = cn.IdPessoa";
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    var resultado = conexao.Query<ColaboradorListagemModel, NomeCompletoModel, EnderecoModel, ContatoModel, ColaboradorListagemModel>(listarColaboradores,
                        (colaboradorListagem, nomeCompleto, enderecoModel, contatoModel) => MapearColaboradorListagem(colaboradorListagem, nomeCompleto, enderecoModel, contatoModel),
                        splitOn: "IdPessoa").AsList();
                    return resultado;
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
                    var query = @"select p.IdPessoa, p.IdPessoa,
                    p.Sexo, p.DataNascimento, p.Cpf, p.IdPessoa,
                    c.IdColaborador, c.Salario, c.Condicao, c.Comissao, p.IdPessoa,
                    p.Nome, p.Sobrenome, p.IdPessoa,
                    e.Cep, e.Logradouro, e.Cidade, e.Uf, e.Complemento, e.Bairro, e.NumeroEndereco, p.IdPessoa,
                    cn.Telefone, cn.Celular, cn.Email, p.IdPessoa,
                    cb.Banco, cb.Agencia, cb.Conta, cb.TipoConta
                    from Pessoa p
                    inner join Colaborador c on p.IdPessoa = c.IdPessoa
                    inner join Endereco e on p.IdPessoa = e.IdPessoa
                    inner join Contato cn on p.IdPessoa = cn.IdPessoa
                    inner join ContaBancaria cb on p.IdPessoa = cb.IdPessoa
                    where c.IdColaborador = @IdColaborador;";

                    return conexao.Query<ColaboradorModel, NomeCompletoModel, EnderecoModel, ContatoModel, ContaBancariaModel, ColaboradorModel>
                        (query, (colaboradorModel, nomeCompleto, endereco, contato, contaBancaria) => 
                        MapearColaboradorModel(colaboradorModel, nomeCompleto, endereco, contato, contaBancaria),
                        new { IdColaborador = id }, splitOn: "IdPessoa").FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static List<ColaboradorListagemModel> BuscarColaboradoresPorNome(string nome)
        {
            const string query = @"select co.IdColaborador, co.Condicao, p.IdPessoa, p.Nome, p.Sobrenome, p.IdPessoa, 
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
                    return conexao.Query<ColaboradorListagemModel, NomeCompletoModel,  EnderecoModel, ContatoModel, ColaboradorListagemModel>(query,
                        (colaboradorListagem, nomeCompleto, endereco, contato) => MapearColaboradorListagem(colaboradorListagem, nomeCompleto, endereco, contato),
                        new { nome }, splitOn: "IdPessoa").AsList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static List<ColaboradorListagemModel> BuscarColaboradoresPorId(int id)
        {
            const string query = @"select c.IdColaborador, c.Condicao, c.Salario, c.Comissao, p.IdPessoa, p.Nome, p.Sobrenome, p.IdPessoa, 
                e.Cep, e.Logradouro, e.Cidade, e.Uf, e.Complemento, e.Bairro, e.NumeroEndereco, p.IdPessoa, 
                cn.Telefone, cn.Celular, cn.Email
                from Pessoa p
                inner join Colaborador c on p.IdPessoa = c.IdPessoa
                inner join Endereco e on p.IdPessoa = e.IdPessoa
                inner join Contato cn on p.IdPessoa = cn.IdPessoa
                where c.IdColaborador = @id";
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {

                    return conexao.Query<ColaboradorListagemModel, NomeCompletoModel, EnderecoModel, ContatoModel, ColaboradorListagemModel>(query,
                        (colaboradorListagem, nomeCompleto, endereco, contato) => MapearColaboradorListagem(colaboradorListagem, nomeCompleto, endereco, contato),
                        new { id }, splitOn: "IdPessoa").AsList();
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
                DataNascimento = @DataNascimento, Cpf =  @Cpf where IdPessoa = @IdPessoa";
                const string updateColaborador = @"update Colaborador set Salario = @Salario, Comissao = @Comissao, Condicao = @Condicao where IdColaborador = @IdColaborador";
                const string updateEndereco = @"update Endereco set Cep = @Cep, Logradouro = @Logradouro, Cidade = @Cidade, 
                Uf = @Uf, Complemento = @Complemento, Bairro = @Bairro, NumeroEndereco = @NumeroEndereco where IdPessoa = @IdPessoa";
                const string updateContato = @"update Contato set Telefone = @Telefone, Celular = @Celular, Email = @Email where IdPessoa = @IdPessoa";
                const string updateContaBancaria = @"update ContaBancaria set Banco = @Banco, Agencia = @Agencia, Conta = @Conta, TipoConta = @TipoConta
                where IdPessoa = @IdPessoa";

                using var conexao = new SqlConexao().Connection();
                conexao.Open();
                using (var transacao = conexao.BeginTransaction())

                {
                    conexao.Execute(updatePessoa, 
                        new {
                            colaborador.IdPessoa,
                            colaborador.NomeCompleto.Nome,
                            colaborador.NomeCompleto.Sobrenome,
                            colaborador.Sexo,
                            colaborador.DataNascimento,
                            Cpf = Metodos.RemoverMascaraDeFormatacao(colaborador.Cpf.RetornarValor)
                        }, transacao);

                    conexao.Execute(updateColaborador, colaborador, transacao);

                    conexao.Execute(updateEndereco,
                        new {
                            colaborador.IdPessoa,
                            colaborador.IdColaborador,
                            Cep = Metodos.RemoverMascaraDeFormatacao(colaborador.Endereco.Cep.RetornarValor),
                            colaborador.Endereco.Logradouro,
                            colaborador.Endereco.Cidade,
                            colaborador.Endereco.Uf,
                            colaborador.Endereco.Complemento,
                            colaborador.Endereco.Bairro,
                            colaborador.Endereco.NumeroEndereco
                        }, transacao);

                    conexao.Execute(updateContato, 
                        new{
                                colaborador.IdPessoa,
                                //Celular = Extencoes.RemoverFormatacao(cliente.Contato.Celular.RetornarValor),
                                colaborador.Contato.Celular,
                                colaborador.Contato.Telefone,
                                colaborador.Contato.Email
                            }
                    , transacao);

                    conexao.Execute(updateContaBancaria, colaborador.ContaBancaria, transacao);

                    transacao.Commit();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void InativarColaborador(ColaboradorModel colaborador)
        {
            var query = @"update Colaborador set Condicao = 'Inativo' where IdColaborador = @IdColaborador";
            try
            {
                using var conexao = new SqlConexao().Connection();
                conexao.Open();
                using (var transacao = conexao.BeginTransaction())
                {

                    conexao.Execute(query, colaborador, transacao);
                    transacao.Commit();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //=======================================================
        public static bool ValidaId(int IdColaborador)
        {
            try
            {
                using var conexao = new SqlConexao().Connection();

                conexao.Open();
                var validaId = conexao.Query(@"SELECT IdPessoa FROM Colaborador WHERE IdColaborador = @IdColaborador", new { IdColaborador }).ToList();

                return validaId.Count != 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //mapeamento
        public static ColaboradorListagemModel MapearColaboradorListagem(ColaboradorListagemModel colaboradorListagem, NomeCompletoModel nomeCompleto,
            EnderecoModel endereco, ContatoModel contato)
        {
            colaboradorListagem.NomeCompleto = nomeCompleto;
            colaboradorListagem.Contato = contato;
            colaboradorListagem.Endereco = endereco;
            return colaboradorListagem;
        }
        public static ColaboradorModel MapearColaboradorModel(ColaboradorModel colaboradorModel, NomeCompletoModel nomeCompleto,
            EnderecoModel endereco, ContatoModel contato, ContaBancariaModel contaBancaria)
        {
            colaboradorModel.NomeCompleto = nomeCompleto;
            colaboradorModel.ContaBancaria = contaBancaria;
            colaboradorModel.Contato = contato;
            colaboradorModel.Endereco = endereco;
            return colaboradorModel;
        }
    }
}