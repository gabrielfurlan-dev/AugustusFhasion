using System.Data;
using System.Data.SqlClient;

namespace AugustusFahsion.DAO
{
    public class SqlConexao
    {
        //Servidor do Estágio:
        //const string connection = @"Data Source=DESKTOP-OEURUSN;Initial Catalog=AugustusFashionDatabase;Integrated Security=True";
        
        //Servidor Pessoal:
        const string connection = @"Data Source=DESKTOP-6EG6G0U\SQLEXPRESS;Initial Catalog=AugustusFashionDataBase;Integrated Security=True";
        
        public IDbConnection Connection() =>
            new SqlConnection(connection);
    }
}
