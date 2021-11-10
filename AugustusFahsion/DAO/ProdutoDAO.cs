using AugustusFahsion.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
namespace AugustusFahsion.DAO
{
    public class ProdutoDAO
    {
        public static void CadastrarProduto(ProdutoModel produto)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    var query = @"insert into Produto values(@Nome, @Fabricante,
                    @PrecoCusto, @PrecoVenda, @CodigoBarras, 
                    @QuantidadeEstoque, @Condicao)";
                    conexao.Query<ProdutoModel>(query, produto);
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<ProdutoModel> ListarProdutos()
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    var query = @"select * from Produto";
                    return conexao.Query<ProdutoModel>(query).AsList();
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<ProdutoModel> ListarProdutosPorId(int id)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    var query = @"select * from Produto where IdProduto = @id";
                    return conexao.Query<ProdutoModel>(query, new { id }).AsList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<ProdutoModel> ListarProdutosPorNome(string nome)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    var query = @"select * from Produto where Nome like @nome + '%'" ;
                    return conexao.Query<ProdutoModel>(query, new { nome }).AsList();
                }
            }
            catch (Exception ex)
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
                    var validaId = conexao.Query(@"SELECT IdProduto FROM Produto WHERE IdProduto = @id", new { id }).ToList();

                    return validaId.Count != 0;
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static ProdutoModel Buscar(int id)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    var query = @"select * from Produto where IdProduto=@id";
                    var parametros = new DynamicParameters();
                    parametros.Add("@id", id, System.Data.DbType.Int32);
                    var resultado = conexao.QueryFirstOrDefault<ProdutoModel>(query, parametros);
                    return resultado;
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public static void AlterarProduto(ProdutoModel produto)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    var query = @"update Produto set Nome = @Nome, Fabricante = @Fabricante, PrecoCusto = @PrecoCusto, 
                    PrecoVenda = @PrecoVenda, QuantidadeEstoque = @QuantidadeEstoque, CodigoBarras = @CodigoBarras, Condicao = @Condicao where IdProduto = @IdProduto";
                    conexao.Query<ProdutoModel>(query, produto);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void ExcluirProduto (ProdutoModel produto)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    var id = produto.IdProduto;
                    conexao.Query(@"delete from Produto where Id=" + id);
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
