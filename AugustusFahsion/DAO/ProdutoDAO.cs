using AugustusFahsion.Model;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AugustusFahsion.DAO
{
    public class ProdutoDAO
    {
        public static void CadastrarProduto(IDbConnection conexao, ProdutoModel produto)
        {
            var query = @"insert into Produto values(@Nome, @Marca, @PrecoCusto, @PrecoVenda, @PrecoPromocao, @CodigoBarras)";
            conexao.Query<ProdutoModel>(query, produto);
        }

        public static List<ProdutoModel> ListarProdutos(IDbConnection conexao)
        {
            var query = @"select * from Produto";
            return conexao.Query<ProdutoModel>(query).AsList();
        }
        public static bool ValidaId(IDbConnection conexao, int id)
        {
            var validaId = conexao.Query(@"SELECT Id FROM Produto WHERE Id=@Id", new { Id = id }).ToList();

            if (validaId.Count != 0)
                return true;
            else
                return false;
        }

        public static ProdutoModel Buscar(IDbConnection conexao, int id)
        {
            var query = @"select * from Produto where Id=@id";
            var parametros = new DynamicParameters();
            parametros.Add("@id", id, System.Data.DbType.Int32);
            var resultado = conexao.QueryFirstOrDefault<ProdutoModel>(query, parametros);
            return resultado;
        }

        public static void AlterarProduto(IDbConnection conexao, ProdutoModel produto)
        {
            var id = produto.Id;
            var query = @"update Produto set Nome = @Nome, Marca = @Marca, PrecoCusto = @PrecoCusto, 
            PrecoVenda = @PrecoVenda, PrecoPromocao = @PrecoPromocao, CodigoBarras = @CodigoBarras where Id=@id";
            conexao.Query<ProdutoModel>(query, produto);
        }

        public static void ExcluirProduto (IDbConnection conexao, ProdutoModel produto)
        {
            var id = produto.Id;
            conexao.Query(@"delete from Produto where Id=" + id);
        }
    }
}
