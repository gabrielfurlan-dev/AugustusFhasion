using System.Data;
using System.Data.SqlClient;

namespace AugustusFahsion.DAO
{
    public class SqlConexao
    {
 
        //String de conexão:
        const string connection = @"Data Source=HOME_PC;Initial" +
            " Catalog=AugustusFashionDatabase;Integrated Security=True";
        
        public IDbConnection Connection() =>
            new SqlConnection(connection);
    }
}
