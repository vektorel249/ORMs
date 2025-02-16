using Dapper;
using Vektorel.Northwind.Erp.Data.DTOs;
using Vektorel.Northwind.Erp.Data.Managers;

namespace Vektorel.Orms.Erp.Data.Repositories;

public class EmployeeRepository : IConnectionManager
{
    private ConnectionManager connectionManager;
    public EmployeeRepository()
    {
        CreateConnection();
    }

    public void CreateConnection()
    {
        connectionManager = new ConnectionManager();
    }

    public List<Option> GetCustomersAsOptions()
    {
        var query = "select EmployeeID as Code, concat(FirstName, ' ', LastName) as Name from Employees order by Name";
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
