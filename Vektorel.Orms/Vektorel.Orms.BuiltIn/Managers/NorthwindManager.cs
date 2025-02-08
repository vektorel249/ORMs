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
        var result = new List<Category>();
        while (reader.Read())
        {
            var category = new Category
            {
                CategoryID = reader.GetInt32(0), // Convert.ToInt32(reader["CategoryId"])
                CategoryName = reader.GetString(1),
                Description = reader["Description"].ToString()
            };
            result.Add(category);
        }

        return result;
    }

    public List<Product> GetProducts()
    {
        throw new NotImplementedException();
    }
}
