using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

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

        public bool IsConnected { get { return sqlConnection.State == ConnectionState.Open; } }

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

        internal void Kill()
        {
            sqlConnection.Close();
            sqlConnection.Dispose();
        }
    }
}
