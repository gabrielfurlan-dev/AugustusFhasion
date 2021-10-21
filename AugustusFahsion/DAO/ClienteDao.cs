using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using AugustusFahsion.Model;
using AugustusFahsion.View;
using Dapper;

namespace AugustusFahsion.DAO
{
    public class ClienteDao
    {
        public static void CadastrarCliente(IDbConnection conexao, ClienteModel cliente)
        {
            var query = @"insert into Cliente values(@Nome, @Email, @Telefone)";
            conexao.Query<ClienteModel>(query, cliente);
        }

        public static List<ClienteModel> ListarClientes(IDbConnection conexao)
        {
            var query = @"select * from Cliente";
            return conexao.Query<ClienteModel>(query).AsList();
        }

        public static bool ValidaId(IDbConnection conexao, int id)
        {
            var validaId = conexao.Query(@"SELECT Id FROM Cliente WHERE Id=@Id", new { Id = id }).ToList();

            if (validaId.Count != 0)
                return true;
            else
                return false;
        }

        //public static string PreencheDados(IDbConnection conexao, string nome, string email, string telefone, ClienteModel cliente)
        //{
        //    var id = cliente.Id;
        //    nome = conexao.Query(@"SELECT Nome FROM Cliente WHERE Id=@id").ToString();
        //    email = conexao.Query(@"SELECT Email FROM Cliente WHERE Id=@id").ToString();
        //    telefone = conexao.Query(@"SELECT Telefone FROM Cliente WHERE Id=@id").ToString();

        //    return nome;
        //}

        public static void AlterarCliente(IDbConnection conexao, ClienteModel cliente)
        {
            var id = cliente.Id;
            var query = @"update Cliente set Nome = @Nome, Email = @Email, Telefone = @Telefone where Id=@id ";
            conexao.Query<ClienteModel>(query, cliente);
        }

        public static void ExcluirCliente(IDbConnection conexao, ClienteModel cliente)
        {
            var id = cliente.Id;
            conexao.Query(@"delete from Clientes where Id=@id");
        }    
    }
}
