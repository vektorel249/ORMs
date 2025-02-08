using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using Vektorel.Orms.Data.Connection;
using Vektorel.Orms.Data.Entities;

namespace Vektorel.Orms.BuiltIn.Managers;

public class NorthwindManager : IDataConnection
{
    public NorthwindManager()
    {
        ConnectionString = "Server=192.168.254.198;Database=Northwind;User Id=va249;Password=123;TrustServerCertificate=true;";
    }
    public string? ConnectionString { get; set; }
    public bool IsConnected { get; set; }

    public DbConnection Connect()
    {
        var connection = new SqlConnection(ConnectionString);
        connection.Open();
        if (connection.State != ConnectionState.Open)
        {
            throw new Exception("Bağlantı sağlanamadı");
        }

        return connection;
    }

    public List<Category> GetCategories()
    {
        var query = "select CategoryID, CategoryName, Description from Categories";
        var connection = Connect();
        //var command = new SqlCommand(query, connection as SqlConnection);
        var command = connection.CreateCommand();
        command.CommandText = query;
        var reader = command.ExecuteReader();
        while (reader.Read())
        {
            Debug.WriteLine("Okudum");
        }

        return null;
    }

    public List<Product> GetProducts()
    {
        throw new NotImplementedException();
    }
}
