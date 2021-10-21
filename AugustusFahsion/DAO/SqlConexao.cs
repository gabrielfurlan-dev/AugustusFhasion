using System.Data;
using System.Data.SqlClient;

namespace AugustusFahsion.DAO
{
    public class SqlConexao
    {
        const string connection = @"Data Source=DESKTOP-OEURUSN;Initial Catalog=AugustusFashionDatabase;Integrated Security=True";

        public IDbConnection Connection() =>
            new SqlConnection(connection);
    }
}
