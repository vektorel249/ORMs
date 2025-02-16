using Dapper;
using Vektorel.Northwind.Erp.Data.DTOs;
using Vektorel.Northwind.Erp.Data.Managers;

namespace Vektorel.Orms.Erp.Data.Repositories;

public class CustomerRepository : IConnectionManager
{
    private ConnectionManager connectionManager;
    public CustomerRepository()
    {
        CreateConnection();
    }

    public void CreateConnection()
    {
        connectionManager = new ConnectionManager();
    }

    public List<Option> GetCustomersAsOptions()
    {
        var query = "select CustomerID as Code, CompanyName as Name from Customers order by Name";
        return connectionManager.GetConnection().Query<Option>(query).ToList();
    }

    public void Dispose()
    {
        if (connectionManager.IsConnected)
        {
            connectionManager.Kill();
        }
    }
}