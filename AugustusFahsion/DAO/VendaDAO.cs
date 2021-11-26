﻿using AugustusFahsion.Model;
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

            var venda = @"insert into Venda (IdCliente, IdColaborador, FormaPagamento, TotalBruto, TotalDesconto, 
		                        TotalLiquido)
                                output inserted.IdVenda
                                values ( @IdCliente, @IdColaborador, @FormaPagamento, 
                                @TotalBruto, @TotalDesconto, @TotalLiquido)";

            var VendaProduto = @"insert VendaProduto (IdProdutoGuid, IdProduto, IdVenda, PrecoVenda, Quantidade,
                                    PrecoLiquido, Desconto, Total) values (@IdProdutoGuid, @IdProduto, @IdVenda , @PrecoVenda,
                                    @Quantidade, @PrecoLiquido, @Desconto, @Total)";

            try
            {
                using var conexao = new SqlConexao().Connection();
                conexao.Open();
                using (var transacao = conexao.BeginTransaction())
                {
                    vendaModel.IdVenda = conexao.ExecuteScalar<int>(venda, vendaModel, transacao);

                    vendaModel.ListaDeItens.ForEach(x => x.IdVenda = vendaModel.IdVenda);

                    conexao.Execute(VendaProduto, vendaModel.ListaDeItens, transacao);

                    AtualizarEstoque(vendaModel, conexao, transacao);

                    transacao.Commit();

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
                                v.FormaPagamento, v.TotalBruto, v.TotalDesconto, v.TotalLiquido, v.Condicao
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
                                    PrecoLiquido, Desconto, Total) values (@IdProdutoGuid, @IdProduto, @IdVenda , @PrecoVenda,
                                    @Quantidade, @PrecoLiquido, @Desconto, @Total)";

                    const string updateVenda = @"update Venda set FormaPagamento =  @FormaPagamento, TotalBruto = @TotalBruto, TotalDesconto = @TotalDesconto, TotalLiquido = @TotalLiquido
                                 where IdVenda = @IdVenda";

                    const string retornarEstoque = @"update Produto set QuantidadeEstoque += @QuantidadeEstoque where IdProduto = @IdProduto";

                    const string queryListaProdutosAntigos = @"select IdProduto, Quantidade from VendaProduto where IdVenda = @IdVenda";



                    List<VendaProdutoModel> listaProdutosAntigos = conexao.Query<VendaProdutoModel>(queryListaProdutosAntigos, new { venda.IdVenda }, transacao).AsList();

                    foreach (var item in listaProdutosAntigos)
                    {
                        conexao.Execute(retornarEstoque, new { IdProduto = item.IdProduto, QuantidadeEstoque = item.Quantidade }, transacao);
                    }

                    conexao.Execute(deleteVendaProduto, new { venda.IdVenda }, transacao);

                    conexao.Execute(insertVendaProduto, venda.ListaDeItens, transacao);

                    conexao.Execute(updateVenda, venda, transacao);

                    AtualizarEstoque(venda, conexao, transacao);

                    transacao.Commit();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        //string deleteVenda = @"update from Venda where IdVenda = @idVenda";
        //conexao.Execute(deleteVenda, venda, transacao);

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
                    var query = @"select vp.IdProduto, vp.Quantidade, vp.PrecoLiquido, vp.Desconto,
                                vp.Total, vp.IdVenda, vp.PrecoVenda, vp.IdProdutoGuid,
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
                    const string query = @"select vp.IdProduto, vp.Quantidade, vp.PrecoLiquido, vp.Desconto,
                                        vp.Total, vp.IdVenda, vp.PrecoVenda, vp.IdProdutoGuid,
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
    }
}
