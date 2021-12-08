using AugustusFahsion.Controller;
using AugustusFahsion.Model;
using AugustusFahsion.Model.Contato;
using AugustusFahsion.Model.Enderecos;
using AugustusFahsion.Model.ValueObjects;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AugustusFahsion.DAO
{
    public class ClienteDAO
    {   
        public static void CadastrarCliente(ClienteModel cliente)
        {
            const string insertPessoa = @"insert into Pessoa output inserted.IdPessoa values
                                        (@Nome, @Sobrenome, @Sexo, @DataNascimento, @Cpf)";

            const string insertCliente = @"insert into Cliente (IdPessoa, ValorLimiteAPrazo) values
                                        (@IdPessoa, @ValorLimiteAPrazo)";

            const string insertEndereco = @"insert into Endereco (IdPessoa, Cep, Logradouro,
                                        Cidade, Uf, Complemento, Bairro, NumeroEndereco) 
                                        values (@IdPessoa, @Cep, @Logradouro, @Cidade, @Uf,
                                        @Complemento, @Bairro, @NumeroEndereco)";

            const string insertContato = @"insert into Contato (IdPessoa, Telefone, Celular, Email) 
                                            values (@IdPessoa, @Telefone, @Celular, @Email)";
            
            try
            {
                using var conexao = new SqlConexao().Connection();
                conexao.Open();
                using (var transacao = conexao.BeginTransaction())
                {
                    int id = conexao.ExecuteScalar<int>(insertPessoa,
                        new
                        {
                            Nome = cliente.NomeCompleto.Nome,
                            Sobrenome = cliente.NomeCompleto.Sobrenome,
                            Sexo = cliente.Sexo,
                            DataNascimento = cliente.DataNascimento,
                            Cpf = Metodos.RemoverMascaraDeFormatacao(cliente.Cpf.RetornarValor)
                        },
                        transacao);
                    cliente.IdPessoa = id;
                    cliente.Endereco.IdPessoa = id;
                    cliente.Contato.IdPessoa = id;

                    conexao.Execute(insertCliente, 
                        new 
                        {
                            cliente.IdPessoa,
                            ValorLimiteAPrazo = cliente.ValorLimiteAPrazo.RetornarValor
                        },
                    transacao);
                    conexao.Execute(insertEndereco, new
                    {
                        IdPessoa = cliente.IdPessoa,
                        Cep = Metodos.RemoverMascaraDeFormatacao(cliente.Endereco.Cep.RetornarValor),
                        Logradouro = cliente.Endereco.Logradouro,
                        Cidade = cliente.Endereco.Cidade,
                        Uf = cliente.Endereco.Uf,
                        Complemento = cliente.Endereco.Complemento,
                        Bairro = cliente.Endereco.Bairro,
                        NumeroEndereco = cliente.Endereco.NumeroEndereco
                    }, transacao);
                    conexao.Execute(insertContato, cliente.Contato, transacao);
                    transacao.Commit();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static ClienteModel BuscarCliente(int id)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    var query = @"select p.IdPessoa, p.Sexo, p.DataNascimento, p.Cpf, p.IdPessoa,
                    c.ValorLimiteAPrazo, c.IdCliente, c.Condicao, p.IdPessoa,
                    p.Nome, p.Sobrenome, p.IdPessoa,
                    e.Cep, e.Logradouro, e.Cidade, e.Uf, e.Complemento, e.Bairro, e.NumeroEndereco, p.IdPessoa,
                    cn.Telefone, cn.Celular, cn.Email
                    from Pessoa p
                    inner join Cliente c on p.IdPessoa = c.IdPessoa
                    inner join Endereco e on p.IdPessoa = e.IdPessoa
                    inner join Contato cn on p.IdPessoa = cn.IdPessoa
                    where c.IdCliente = @IdCliente;";

                    return conexao.Query<ClienteModel, NomeCompletoModel, EnderecoModel, ContatoModel, ClienteModel>
                        (query, (clienteModel, nomeCompleto, enderecoModel, contatoModel) =>
                        MapearClienteAlterar(clienteModel, nomeCompleto, enderecoModel, contatoModel),
                        new { IdCliente = id }, splitOn: "IdPessoa").FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<ClienteListagemModel> BuscarClientePorNome(string nome)
        {
            const string listarPessoa = @"select c.IdPessoa, c.IdCliente, c.Condicao, p.IdPessoa, p.Nome, p.Sobrenome, p.IdPessoa,
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
                    return conexao.Query<ClienteListagemModel, NomeCompletoModel, EnderecoModel, ContatoModel, ClienteListagemModel>(listarPessoa,
                        (clienteListagem, nomeCompleto, endereco, contato) => MapearClienteListagem(clienteListagem, nomeCompleto, endereco, contato),
                        new { nome }, splitOn: "IdPessoa").AsList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<ClienteListagemModel> BuscarClientePorId(int id)
        {
            const string listarPessoa = @"select c.IdPessoa, c.IdCliente, c.Condicao, p.IdPessoa, p.Nome, p.Sobrenome, p.IdPessoa, e.Cep, 
                e.Logradouro, e.Cidade, e.Uf, e.Complemento, e.Bairro, e.NumeroEndereco, p.IdPessoa, cn.Telefone, cn.Celular, cn.Email,
                from Pessoa p
                inner join Cliente c on p.IdPessoa = c.IdPessoa
                inner join Endereco e on p.IdPessoa = e.IdPessoa
                inner join Contato cn on p.IdPessoa = cn.IdPessoa 
                where p.IdPessoa = @id";
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    return conexao.Query<ClienteListagemModel, NomeCompletoModel, EnderecoModel, ContatoModel, ClienteListagemModel>(listarPessoa,
                        (clienteListagem, nomeCompleto, endereco, contato) => MapearClienteListagem(clienteListagem, nomeCompleto, endereco, contato),
                        new { id }, splitOn: "IdPessoa").AsList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<ClienteListagemModel> ListarClientes()
        {
            const string listarPessoa = @"select c.IdPessoa, p.IdPessoa, p.Nome, p.Sobrenome, p.IdPessoa,
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
                    return conexao.Query<ClienteListagemModel, NomeCompletoModel, EnderecoModel, ContatoModel, ClienteListagemModel>(listarPessoa,
                        (clienteListagem, nomeCompleto, endereco, contato) => MapearClienteListagem(clienteListagem, nomeCompleto, endereco, contato),
                        splitOn: "IdPessoa"
                        ).AsList();
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
                const string updatePessoa = @"update Pessoa set Nome = @Nome, Sobrenome = @Sobrenome, Sexo = @Sexo, 
                DataNascimento = @DataNascimento, Cpf = @Cpf where IdPessoa = @IdPessoa";

                const string updateCliente = @"update Cliente set ValorLimiteAPrazo = @ValorLimiteAPrazo, Condicao = @Condicao where IdPessoa = @IdPessoa";

                const string updateEndereco = @"update Endereco set Cep = @Cep, Logradouro = @Logradouro, Cidade = @Cidade, 
                Uf = @Uf, Complemento = @Complemento, Bairro = @Bairro, NumeroEndereco = @NumeroEndereco where IdPessoa = @IdPessoa";

                const string updateContato = @"update Contato set Telefone = @Telefone, Celular = @Celular, Email = @Email where IdPessoa = @IdPessoa";


                using var conexao = new SqlConexao().Connection();
                conexao.Open();
                using (var transacao = conexao.BeginTransaction())
                {
                    conexao.Execute(updatePessoa,
                        new
                        {
                            cliente.IdPessoa,
                            cliente.NomeCompleto.Nome,
                            cliente.NomeCompleto.Sobrenome,
                            cliente.Sexo,
                            cliente.DataNascimento,
                            Cpf = Metodos.RemoverMascaraDeFormatacao(cliente.Cpf.RetornarValor)
                        }, transacao);

                    conexao.Execute(updateCliente, 
                        new
                        {
                            cliente.IdPessoa,
                            ValorLimiteAPrazo = cliente.ValorLimiteAPrazo.RetornarValor,
                            cliente.Condicao
                        }, 
                    transacao);

                    conexao.Execute(updateEndereco,
                        new
                        {
                            cliente.IdPessoa,
                            Cep = Metodos.RemoverMascaraDeFormatacao(cliente.Endereco.Cep.RetornarValor),
                            cliente.Endereco.Logradouro,
                            cliente.Endereco.Cidade,
                            cliente.Endereco.Uf,
                            cliente.Endereco.Complemento,
                            cliente.Endereco.Bairro,
                            cliente.Endereco.NumeroEndereco
                        }, transacao);

                    conexao.Execute(updateContato,
                        new
                        {
                            IdPessoa = cliente.IdPessoa,
                            //Celular = Extencoes.RemoverFormatacao(cliente.Contato.Celular.RetornarValor),
                            cliente.Contato.Celular,
                            cliente.Contato.Telefone,
                            cliente.Contato.Email
                        }, transacao);
                    transacao.Commit();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static ClienteListagemModel MapearClienteListagem(ClienteListagemModel clienteListagem, 
            NomeCompletoModel nomeCompleto, EnderecoModel endereco, ContatoModel contato)
        {
            clienteListagem.NomeCompleto = nomeCompleto;
            clienteListagem.Contato = contato;
            clienteListagem.Endereco = endereco;
            return clienteListagem;
        }

        public static ClienteModel MapearClienteAlterar(ClienteModel clienteModel,
            NomeCompletoModel nomeCompleto, EnderecoModel endereco, ContatoModel contato)
        {
            clienteModel.NomeCompleto = nomeCompleto;
            clienteModel.Contato = contato;
            clienteModel.Endereco = endereco;
            return clienteModel;
        }


        public static decimal ValorLimiteGasto(int id) 
        {
            const string query = @"SELECT Sum(vp.TotalLiquido) 
                                    FROM VendaProduto vp
                                    INNER JOIN Venda v ON vp.IdVenda = v.IdVenda
                                    WHERE v.FormaPagamento = 'A prazo' and v.IdCliente = @id and v.Condicao = 'Ativa'";

            using var conexao = new SqlConexao().Connection();
            conexao.Open();
            {
                try
                {
                    var valor = conexao.ExecuteScalar<decimal>(query, new { id });
                    return valor;
                }
                catch (Exception ex) 
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        //
        public static bool ValidaId(int id)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    var validaId = conexao.Query(@"SELECT IdPessoa FROM Cliente WHERE IdPessoa=@IdPessoa", new { IdPessoa = id }).ToList();

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
    }
}