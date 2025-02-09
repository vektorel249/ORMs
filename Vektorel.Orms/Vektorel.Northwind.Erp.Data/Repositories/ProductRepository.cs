using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vektorel.Northwind.Erp.Data.Entities;
using Vektorel.Northwind.Erp.Data.Managers;

namespace Vektorel.Orms.Erp.Data.Repositories
{
    public class ProductRepository : IConnectionManager
    {
        private ConnectionManager connectionManager;
        public ProductRepository()
        {
            CreateConnection();
        }
        public void CreateConnection()
        {
            connectionManager = new ConnectionManager();
        }

        public List<Product> GetProducts()
        {
            var query = "select * from Products";
            return connectionManager.GetConnection().Query<Product>(query).ToList();
        }
    }
}


// YAGNI : You Aren't Gonna Need It
// KISS  : Keep It Simple & Stupid
// SOLID : 