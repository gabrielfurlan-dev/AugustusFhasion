using AugustusFahsion.Model;
using AugustusFahsion.Model.Venda;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AugustusFahsion.DAO
{
    public class VendaDAO
    {
        public static void RegistrarVenda(VendaModel vendaModel)
        {

            var insertVenda = @"insert into Venda (IdCliente, IdColaborador, FormaPagamento, TotalBruto, TotalDesconto, 
		                        TotalLiquido, Datavenda, Pago)
                                output inserted.IdVenda
                                values ( @IdCliente, @IdColaborador, @FormaPagamento, 
                                @TotalBruto, @TotalDesconto, @TotalLiquido, @Datavenda, @Pago)";

            var insertVendaProduto = @"insert VendaProduto (IdProdutoGuid, IdProduto, IdVenda, PrecoVenda, Quantidade,
                                    TotalLiquido, Desconto, TotalBruto) values (@IdProdutoGuid, @IdProduto, @IdVenda , @PrecoVenda,
                                    @Quantidade, @TotalLiquido, @Desconto, @TotalBruto)";

            try
            {
                using var conexao = new SqlConexao().Connection();
                conexao.Open();
                using var transacao = conexao.BeginTransaction();

                vendaModel.IdVenda = conexao.ExecuteScalar<int>(insertVenda, new
                {
                    vendaModel.Cliente.IdCliente,
                    vendaModel.IdColaborador,
                    vendaModel.FormaPagamento,
                    TotalBruto = vendaModel.TotalBruto.RetornarValor,
                    TotalDesconto = vendaModel.TotalDesconto.RetornarValor,
                    TotalLiquido = vendaModel.TotalLiquido.RetornarValor,
                    vendaModel.DataVenda,
                    vendaModel.Pago
                }, transacao);

                vendaModel.ListaDeItens.ForEach(x => x.IdVenda = vendaModel.IdVenda);

                foreach (var item in vendaModel.ListaDeItens)
                {
                    conexao.Execute(insertVendaProduto, new
                    {
                        item.IdProdutoGuid,
                        item.IdProduto,
                        IdVenda = item.IdVenda,
                        PrecoVenda = item.PrecoVenda.RetornarValor,
                        item.Quantidade,
                        TotalLiquido = item.TotalLiquido.RetornarValor,
                        item.Desconto,
                        TotalBruto = item.TotalBruto.RetornarValor

                    }, transacao);
                }

                AtualizarEstoque(vendaModel, conexao, transacao);

                transacao.Commit();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<VendaListagemModel> FiltrarPorCliente(string nomeCliente)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    var query = @"select v.IdVenda, p.Nome as NomeCliente, p2.Nome as NomeColaborador,
                                v.FormaPagamento, v.TotalBruto, v.TotalDesconto, v.TotalLiquido, v.Condicao, v.Pago, v.Datavenda
                                from Venda v
                                inner join Cliente c on v.IdCliente = c.IdCliente
                                inner join Colaborador co on v.IdColaborador = co.IdColaborador
                                inner join Pessoa p on p.IdPessoa = c.IdPessoa 
                                inner join Pessoa p2 on p2.IdPessoa = co.IdPessoa
                                WHERE p.Nome LIKE @nomeCliente + '%'";

                    var lista = conexao.Query<VendaListagemModel>(query, new { nomeCliente }).ToList();
                    return lista;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal static List<VendaListagemModel> FiltrarPorProduto(string nomeProduto)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    var query = @"select v.IdVenda, p.Nome as NomeCliente, p2.Nome as NomeColaborador,
                                v.FormaPagamento, v.TotalBruto, v.TotalDesconto, v.TotalLiquido, v.Condicao, v.Pago, v.Datavenda
                                from Venda v
                                inner join Cliente c on v.IdCliente = c.IdCliente
                                inner join Colaborador co on v.IdColaborador = co.IdColaborador
                                inner join Pessoa p on p.IdPessoa = c.IdPessoa 
                                inner join Pessoa p2 on p2.IdPessoa = co.IdPessoa
                                inner join VendaProduto vp on v.IdVenda = vp.IdVenda
                                inner join Produto pr on vp.IdProduto = pr.IdProduto
                                WHERE pr.Nome LIKE @nomeProduto + '%'";

                    var lista = conexao.Query<VendaListagemModel>(query, new { nomeProduto }).ToList();
                    return lista;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<VendaListagemModel> FiltrarPorColaborador(string nomeColaborador)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    var query = @"select v.IdVenda, p.Nome as NomeCliente, p2.Nome as NomeColaborador,
                                v.FormaPagamento, v.TotalBruto, v.TotalDesconto, v.TotalLiquido, v.Condicao, v.Pago, v.Datavenda
                                from Venda v
                                inner join Cliente c on v.IdCliente = c.IdCliente
                                inner join Colaborador co on v.IdColaborador = co.IdColaborador
                                inner join Pessoa p on p.IdPessoa = c.IdPessoa 
                                inner join Pessoa p2 on p2.IdPessoa = co.IdPessoa
                                WHERE p2.Nome LIKE @nomeColaborador + '%'";

                    var lista = conexao.Query<VendaListagemModel>(query, new { nomeColaborador }).AsList();
                    return lista;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        internal static int BuscarQuantidadeOriginalDaVenda(int idProduto, int idVenda)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    var query = @"select Quantidade from VendaProduto where IdVenda=@IdVenda and IdProduto=@IdProduto";
                    return conexao.Query<int>(query, new { idProduto, idVenda }).FirstOrDefault();
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
                                v.FormaPagamento, v.TotalBruto, v.TotalDesconto, v.TotalLiquido, v.Condicao, v.Pago, v.DataVenda
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
                                v.FormaPagamento, v.TotalBruto, v.TotalDesconto, v.TotalLiquido, v.DataVenda
					            from Venda v
                                inner join Cliente c on v.IdCliente = c.IdCliente
					            inner join Colaborador co on v.IdColaborador = co.IdColaborador
					            inner join Pessoa p on p.IdPessoa = c.IdPessoa 
					            inner join Pessoa p2 on p2.IdPessoa = co.IdPessoa
                                where IdVenda=@idVenda";

                    return conexao.Query<VendaListagemModel>(query, new { idVenda }).AsList();
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
                    var query = @"select IdVenda, IdColaborador, FormaPagamento, Condicao, DataVenda,
                                TotalBruto, TotalDesconto, TotalLiquido, IdVenda, IdCliente from Venda 
                                where IdVenda = @id";
                    var resultado = conexao.Query<VendaModel, ClienteModel, VendaModel>(query,
                        (vendaModel, cliente) => MapearVenda(vendaModel, cliente),
                        new { id }, splitOn: "IdVenda").FirstOrDefault();
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void AlterarVenda(VendaModel venda)
        {
            try
            {
                using var conexao = new SqlConexao().Connection();
                conexao.Open();
                using (var transacao = conexao.BeginTransaction())
                {
                    const string deleteVendaProduto = @"delete VendaProduto where IdVenda = @IdVenda";

                    const string insertVendaProduto = @"insert into VendaProduto (IdProdutoGuid, IdProduto, IdVenda, PrecoVenda, Quantidade,
                                    TotalLiquido, Desconto, TotalBruto) values (@IdProdutoGuid, @IdProduto, @IdVenda , @PrecoVenda,
                                    @Quantidade, @TotalLiquido, @Desconto, @TotalBruto)";

                    const string updateVenda = @"update Venda set FormaPagamento =  @FormaPagamento, TotalBruto = @TotalBruto, TotalDesconto = TotalDesconto, TotalLiquido = @TotalLiquido, Pago = @Pago where IdVenda = @IdVenda";

                    const string retornarEstoque = @"update Produto set QuantidadeEstoque += @QuantidadeEstoque where IdProduto = @IdProduto";

                    const string queryListaProdutosAntigos = @"select IdProduto, Quantidade from VendaProduto where IdVenda = @IdVenda";



                    List<VendaProdutoModel> listaProdutosAntigos = conexao.Query<VendaProdutoModel>(queryListaProdutosAntigos, new { venda.IdVenda }, transacao).AsList();

                    foreach (var item in listaProdutosAntigos)
                    {
                        conexao.Execute(retornarEstoque, new { IdProduto = item.IdProduto, QuantidadeEstoque = item.Quantidade }, transacao);
                    }

                    conexao.Execute(deleteVendaProduto, new { venda.IdVenda }, transacao);

                    foreach (var item in venda.ListaDeItens)
                    {
                        conexao.Execute(insertVendaProduto, new {
                            item.IdProdutoGuid,
                            item.IdProduto,
                            item.IdVenda,
                            PrecoVenda = item.PrecoVenda.RetornarValor,
                            item.Quantidade,
                            TotalLiquido = item.TotalLiquido.RetornarValor,
                            item.Desconto,
                            TotalBruto = item.TotalBruto.RetornarValor

                        }, transacao);
                    }

                    conexao.Execute(updateVenda, 
                        new {
                            venda.FormaPagamento,
                            venda.IdVenda,
                            TotalBruto = venda.TotalBruto.RetornarValor,
                            TotalDesconto = venda.TotalDesconto.RetornarValor,
                            TotalLiquido = venda.TotalLiquido.RetornarValor,
                            Pago = venda.Pago
                        }, transacao);

                    AtualizarEstoque(venda, conexao, transacao);

                    transacao.Commit();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void AtualizarEstoque(VendaModel vendaModel, IDbConnection conexao, IDbTransaction transacao)
        {
            string query = @"update Produto set QuantidadeEstoque -= @QuantidadeEstoque where IdProduto = @IdProduto";

            try
            {
                foreach (var item in vendaModel.ListaDeItens)
                {
                    conexao.Execute(query, new { IdProduto = item.IdProduto, QuantidadeEstoque = item.Quantidade }, transacao);
                }
            }
            catch (Exception ex)
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
                    var query = @"select vp.IdProduto, vp.Quantidade, vp.TotalLiquido, vp.Desconto,
                                vp.TotalBruto, vp.IdVenda, vp.PrecoVenda, vp.IdProdutoGuid,
					            p.Nome

					            from VendaProduto vp
					            inner join Produto p on vp.IdProduto = p.IdProduto
					            where IdVenda = @idVenda";

                    return conexao.Query<VendaProdutoModel>(query, new { idVenda }, transacao).AsList();
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
                    const string query = @"select vp.IdProduto, vp.Quantidade, vp.TotalLiquido, vp.Desconto,
                                        vp.TotalBruto, vp.IdVenda, vp.PrecoVenda, vp.IdProdutoGuid,
					                    p.Nome

					                    from VendaProduto vp
					                    inner join Produto p on vp.IdProduto = p.IdProduto
					                    where vp.IdProduto = @idProduto";

                    return conexao.QueryFirstOrDefault<VendaProdutoModel>(query, new { idProduto }, transacao);
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public static void InativarVenda(VendaModel vendaModel)
        {
            try
            {
                using var conexao = new SqlConexao().Connection();
                conexao.Open();
                using (var transacao = conexao.BeginTransaction())
                {
                    const string inativarVenda = @"update Venda set Condicao = 'Inativa' where IdVenda = @idVenda";
                    const string devolverProdutos = @"update Produto set QuantidadeEstoque += @Quantidade where IdProduto = @IdProduto";

                    conexao.Execute(inativarVenda, vendaModel, transacao);
                    conexao.Execute(devolverProdutos, vendaModel.ListaDeItens, transacao);

                    transacao.Commit();
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        //Filtros
        public static List<VendaListagemModel> FiltrarPorData(DateTime dataInicial, DateTime dataFinal) 
        {
            try
            {
                using (var conexao = new SqlConexao().Connection()) 
                { 
                    conexao.Open();
                    var query = @"select v.IdVenda, p.Nome as NomeCliente, p2.Nome as NomeColaborador,
                                v.FormaPagamento, v.TotalBruto, v.TotalDesconto, v.TotalLiquido, v.Condicao, v.Pago, v.Datavenda
                                from Venda v
                                inner join Cliente c on v.IdCliente = c.IdCliente
                                inner join Colaborador co on v.IdColaborador = co.IdColaborador
                                inner join Pessoa p on p.IdPessoa = c.IdPessoa 
                                inner join Pessoa p2 on p2.IdPessoa = co.IdPessoa
                                WHERE v.DataVenda BETWEEN @dataInicial and @dataFinal";

                    return conexao.Query<VendaListagemModel>(query, new { dataInicial, dataFinal }).AsList();
                }
                    
            }
            catch (Exception ex)
            {

                throw new Exception (ex.Message);
            }
        }

        //Mapeamento
        public static VendaModel MapearVenda(VendaModel vendaModel, ClienteModel cliente)
        {
            vendaModel.Cliente = cliente;
            return vendaModel;
        }
    }
}
