using Dapper;
using Vektorel.Northwind.Erp.Data.DTOs;
using Vektorel.Northwind.Erp.Data.Managers;

namespace Vektorel.Orms.Erp.Data.Repositories
{
    public class SupplierRepository : IConnectionManager
    {
        private ConnectionManager connectionManager;

        public SupplierRepository()
        {
            CreateConnection();
        }
        public void CreateConnection()
        {
            connectionManager = new ConnectionManager();
        }

        public List<Option> GetSuppliers()
        {
            var query = "select SupplierID as Code, CompanyName as Name from Suppliers order by Name";
            return connectionManager.GetConnection().Query<Option>(query).ToList();
        }
    }
}
