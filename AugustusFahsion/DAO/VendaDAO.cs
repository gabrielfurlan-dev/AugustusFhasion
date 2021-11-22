using AugustusFahsion.Model;
using AugustusFahsion.Model.Venda;
using Dapper;
using System;
using System.Collections.Generic;

namespace AugustusFahsion.DAO
{
    public class VendaDAO
    {
        public static void RegistrarVenda(VendaModel vendaModel)
        {
            string updateEstoque = @"update Produto set QuantidadeEstoque -= @Quantidade where IdProduto = @IdProduto";


            var venda = @"insert into Venda (IdCliente, IdColaborador, FormaPagamento, TotalBruto, TotalDesconto, 
		                        TotalLiquido, Condicao)
                                output inserted.IdVenda
                                values ( @IdCliente, @IdColaborador, @FormaPagamento, 
                                @TotalBruto, @TotalDesconto, @TotalLiquido)";

            var VendaProduto = @"insert VendaProduto (IdProdutoGuid, IdProduto, IdVenda, PrecoVenda, Quantidade,
                                    PrecoLiquido, Desconto, Total) values (@IdProdutoGuid, @IdProduto, @IdVenda , @PrecoVenda,
                                    @Quantidade, @PrecoLiquido, @Desconto, @Total, 'Ativo')";

            try
            {
                using var conexao = new SqlConexao().Connection();
                conexao.Open(); 
                using (var transacao = conexao.BeginTransaction())
                {
                    vendaModel.IdVenda = conexao.ExecuteScalar<int>(venda, vendaModel,transacao);

                    vendaModel.ListaDeItens.ForEach(x => x.IdVenda = vendaModel.IdVenda);

                    conexao.Execute(VendaProduto, vendaModel.ListaDeItens, transacao);

                    conexao.Execute(updateEstoque, vendaModel.ListaDeItens, transacao);


                    transacao.Commit();

                }
            }
            catch (Exception ex) 
            { 
                 throw new Exception(ex.Message);
            }
        }
        public static List<VendaListagemModel> ListarVendas()
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    var query = @"select v.IdVenda, p.Nome as NomeCliente, p2.Nome as NomeColaborador,
                                v.FormaPagamento, v.TotalBruto, v.TotalDesconto, v.TotalLiquido
					            from Venda v
                                inner join Cliente c on v.IdCliente = c.IdCliente
					            inner join Colaborador co on v.IdColaborador = co.IdColaborador
					            inner join Pessoa p on p.IdPessoa = c.IdPessoa 
					            inner join Pessoa p2 on p2.IdPessoa = co.IdPessoa";

                    return conexao.Query<VendaListagemModel>(query).AsList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<VendaListagemModel> ListarVendaSelecionada(int idVenda)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    var query = @"select v.IdVenda, p.Nome as NomeCliente, p2.Nome as NomeColaborador,
                                v.FormaPagamento, v.TotalBruto, v.TotalDesconto, v.TotalLiquido
					            from Venda v
                                inner join Cliente c on v.IdCliente = c.IdCliente
					            inner join Colaborador co on v.IdColaborador = co.IdColaborador
					            inner join Pessoa p on p.IdPessoa = c.IdPessoa 
					            inner join Pessoa p2 on p2.IdPessoa = co.IdPessoa
                                where IdVenda=@idVenda";

                    return conexao.Query<VendaListagemModel>(query, new { idVenda}).AsList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static VendaModel BuscarVenda(int id)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    var query = @"select * from Venda where IdVenda=@id";
                    var parametros = new DynamicParameters();
                    parametros.Add("@id", id, System.Data.DbType.Int32);
                    var resultado = conexao.QueryFirstOrDefault<VendaModel>(query, parametros);
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //public static List<ClienteListagemModel> BuscarClientePorNome(string nome)
        //{
        //    const string listarPessoa = @"select c.IdPessoa, c.IdCliente, p.IdPessoa, p.Nome, p.Sobrenome, p.IdPessoa,
        //        e.Cep, e.Logradouro, e.Cidade, e.Uf, e.Complemento, e.Bairro, e.NumeroEndereco, p.IdPessoa,
        //        cn.Telefone, cn.Celular, cn.Email
        //        from Pessoa p
        //        inner join Cliente c on p.IdPessoa = c.IdPessoa
        //        inner join Endereco e on p.IdPessoa = e.IdPessoa
        //        inner join Contato cn on p.IdPessoa = cn.IdPessoa
        //        where p.Nome like @nome + '%'";
        //    try
        //    {
        //        using (var conexao = new SqlConexao().Connection())
        //        {
        //            //return conexao.Query<ClienteListagemModel, NomeCompletoModel, EnderecoModel, ContatoModel, ClienteListagemModel>(listarPessoa,
        //            //    (clienteListagem, nomeCompleto, endereco, contato) => MapearClienteListagem(clienteListagem, nomeCompleto, endereco, contato),
        //            //    new { nome }, splitOn: "IdPessoa").AsList();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        //public static List<ClienteListagemModel> BuscarClientePorId(int id)
        //{
        //    const string listarPessoa = @"select c.IdPessoa, c.IdCliente. p.IdPessoa, p.Nome, p.Sobrenome, p.IdPessoa, e.Cep, 
        //        e.Logradouro, e.Cidade, e.Uf, e.Complemento, e.Bairro, e.NumeroEndereco, p.IdPessoa, cn.Telefone, cn.Celular, cn.Email,
        //        from Pessoa p
        //        inner join Cliente c on p.IdPessoa = c.IdPessoa
        //        inner join Endereco e on p.IdPessoa = e.IdPessoa
        //        inner join Contato cn on p.IdPessoa = cn.IdPessoa 
        //        where p.IdPessoa = @id";
        //    try
        //    {
        //        using (var conexao = new SqlConexao().Connection())
        //        {
        //            //return conexao.Query<ClienteListagemModel, NomeCompletoModel, EnderecoModel, ContatoModel, ClienteListagemModel>(listarPessoa,
        //            //    (clienteListagem, nomeCompleto, endereco, contato) => MapearClienteListagem(clienteListagem, nomeCompleto, endereco, contato),
        //            //    new { id }, splitOn: "IdPessoa").AsList();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        public static void ExcluirVenda(VendaModel venda) 
        {
            try
            {
                using var conexao = new SqlConexao().Connection();
                conexao.Open();
                using (var transacao = conexao.BeginTransaction())
                {
                    string deleteVendaProduto = @"delete from VendaProduto where IdVenda = @idVenda";
                    string deleteVenda = @"delete from Venda where IdVenda = @idVenda";

                    var idVenda = venda.IdVenda;
                    conexao.Execute(deleteVendaProduto, transacao);
                    conexao.Execute(deleteVenda, transacao);
                    transacao.Commit();
                }
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
        public static void AtualizarEstoque(VendaModel vendaModel) 
        {
            string query = @"update Produto QuantidadeEstoque = QuantidadeEstoque - @QuantidadeEstoque where IdProduto = @IdProduto";

            try
            {
                using var conexao = new SqlConexao().Connection();
                conexao.Open();
                using (var transacao = conexao.BeginTransaction()) 
                {
                    conexao.Execute(query, vendaModel.ListaDeItens, transacao);
                    transacao.Commit();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<VendaProdutoModel> ListarProdutosDaVenda(int idVenda) 
        {
            try
            {
                using var conexao = new SqlConexao().Connection();
                conexao.Open();
                using (var transacao = conexao.BeginTransaction()) 
                {
                    var query = @"select vp.IdProduto, vp.Quantidade, vp.PrecoLiquido, vp.Desconto,
                                vp.Total, vp.IdVenda, vp.PrecoVenda, vp.IdProdutoGuid,
					            p.Nome

					            from VendaProduto vp
					            inner join Produto p on vp.IdProduto = p.IdProduto
					            where IdVenda = @idVenda";

                    return conexao.Query< VendaProdutoModel>(query, new { idVenda }, transacao).AsList();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public static VendaProdutoModel BuscarDadosDoProdutoDaVenda(int idProduto) 
        {
            try
            {
                using var conexao = new SqlConexao().Connection();
                conexao.Open();
                using (var transacao = conexao.BeginTransaction())
                {
                    var query = @"select vp.IdProduto, vp.Quantidade, vp.PrecoLiquido, vp.Desconto,
                                vp.Total, vp.IdVenda, vp.PrecoVenda, vp.IdProdutoGuid,
					            p.Nome

					            from VendaProduto vp
					            inner join Produto p on vp.IdProduto = p.IdProduto
					            where vp.IdProduto = @idProduto";

                    var resultado = conexao.QueryFirstOrDefault<VendaProdutoModel>(query, new { idProduto }, transacao);
                    return resultado;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
