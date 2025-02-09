using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Vektorel.Northwind.Erp.Data.Managers
{
    internal class ConnectionManager
    {
        private readonly SqlConnection sqlConnection;
        public ConnectionManager() 
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
        }
        
        private void Open()
        {
            if (sqlConnection.State != System.Data.ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }

        public SqlConnection GetConnection() 
        {
            Open();
            return sqlConnection; 
        }
    }
}
