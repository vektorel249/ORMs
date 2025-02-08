using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;
using Vektorel.Orms.Data.Connection;
using Vektorel.Orms.Data.Entities;

namespace Vektorel.Orms.DapperLib.Managers;

public class NorthwindManager : IDataConnection
{
    public NorthwindManager()
    {
        ConnectionString = "Server=192.168.254.198;Database=Northwind;User Id=va249;Password=123;TrustServerCertificate=true;";
    }
    public string? ConnectionString { get; set; }

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
        using var connection = Connect();
        return connection.Query<Category>(query).ToList();
    }

    public IEnumerable<Product> GetProducts()
    {
        var query = "select ProductID, ProductName, UnitPrice, UnitsInStock from Products";
        using var connection = Connect();
        return connection.Query<Product>(query);
    }
}
