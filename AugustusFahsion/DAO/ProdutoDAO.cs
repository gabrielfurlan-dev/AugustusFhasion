using AugustusFahsion.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
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
                    var query = @"insert into Produto values(@Nome, @Marca, @PrecoCusto, @PrecoVenda, @PrecoPromocao, @CodigoBarras)";
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
        public static bool ValidaId(int id)
        {
            try
            {
                using (var conexao = new SqlConexao().Connection())
                {
                    var validaId = conexao.Query(@"SELECT Id FROM Produto WHERE Id=@Id", new { Id = id }).ToList();

                    if (validaId.Count != 0)
                        return true;
                    else
                        return false;
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
                    var query = @"select * from Produto where Id=@id";
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
                    var id = produto.Id;
                    var query = @"update Produto set Nome = @Nome, Marca = @Marca, PrecoCusto = @PrecoCusto, 
                    PrecoVenda = @PrecoVenda, PrecoPromocao = @PrecoPromocao, CodigoBarras = @CodigoBarras where Id=@id";
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
                    var id = produto.Id;
                    conexao.Query(@"delete from Produto where Id=" + id);
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
