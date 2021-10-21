using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AugustusFahsion.Model;
using Dapper;

namespace AugustusFahsion.DAO
{
    class ColaboradorDAO
    {
        public static void CadastrarColaborador(IDbConnection conexao, ColaboradorModel colaborador)
        {
            var query = @"insert into Colaborador values(@Nome, @Email, @Telefone)";
            conexao.Query<ColaboradorModel>(query, colaborador);
        }

        public static List<ColaboradorModel> ListarColaboradores(IDbConnection conexao)
        {
            var query = @"select * from Colaborador";
            return conexao.Query<ColaboradorModel>(query).AsList();
        }
    }
}
