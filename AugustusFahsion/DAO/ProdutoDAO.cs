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
                    @QuantidadeEstoque, @Condicao, @ImagemProduto)";
                    conexao.Query<ProdutoModel>(query, 
                        new 
                        {
                            produto.Nome,
                            produto.Fabricante,
                            PrecoCusto = produto.PrecoCusto.RetornarValor,
                            PrecoVenda = produto.PrecoVenda.RetornarValor,
                            produto.CodigoBarras,
                            produto.QuantidadeEstoque,
                            produto.Condicao,
                            produto.ImagemProduto
                        }
                    );


                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //listar produtos
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

        internal static int BuscarEstoqueOriginal(int idProduto)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    conexao.Open();
                    var query = @"select QuantidadeEstoque from Produto where IdProduto=@idProduto";
                    return conexao.Query<int>(query, new { idProduto }).FirstOrDefault();
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
                    var query = @"select * from Produto where Nome like @nome + '%'";
                    return conexao.Query<ProdutoModel>(query, new { nome }).AsList();
                }
            }
            catch (Exception ex)
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

        //listar produtos ativos
        public static List<ProdutoModel> ListarProdutosAtivos()
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    var query = @"select * from Produto where Condicao = 'Ativo';";
                    return conexao.Query<ProdutoModel>(query).AsList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static List<ProdutoModel> ListarProdutosAtivosPorId(int id)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    var query = @"select * from Produto where IdProduto = @id and Condicao = 'Ativo'";
                    return conexao.Query<ProdutoModel>(query, new { id }).AsList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static List<ProdutoModel> ListarProdutosAtivosPorNome(string nome)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    var query = @"select * from Produto where Nome like @nome + '%' and Condicao = 'Ativo';";
                    return conexao.Query<ProdutoModel>(query, new { nome }).AsList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //alterar
        public static void AlterarProduto(ProdutoModel produto)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    var query = @"update Produto set 
                                Nome = @Nome, 
                                Fabricante = @Fabricante, 
                                PrecoCusto = @PrecoCusto, 
                                PrecoVenda = @PrecoVenda, 
                                QuantidadeEstoque = @QuantidadeEstoque, 
                                CodigoBarras = @CodigoBarras, 
                                Condicao = @Condicao,
                                ImagemProduto = @ImagemProduto
                                where IdProduto = @IdProduto";

                    conexao.Query<ProdutoModel>(query, 
                        new 
                        { 
                            produto.IdProduto,
                            produto.Nome,
                            produto.Fabricante,
                            PrecoCusto = produto.PrecoCusto.RetornarValor,
                            PrecoVenda = produto.PrecoVenda.RetornarValor,
                            produto.QuantidadeEstoque,
                            produto.CodigoBarras,
                            produto.Condicao,
                            produto.ImagemProduto
                        }
                    );
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //excluir
        public static void ExcluirProduto (ProdutoModel produto)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    var id = produto.IdProduto;
                    conexao.Query(@"update Produto set Condicao = 'Inativo' where Id=" + id);
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
                    var validaId = conexao.Query(@"SELECT IdProduto FROM Produto WHERE IdProduto = @id", new { id }).ToList();

                    return validaId.Count != 0;
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
