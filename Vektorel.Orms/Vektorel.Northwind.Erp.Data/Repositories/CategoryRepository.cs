using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vektorel.Northwind.Erp.Data.Entities;
using Vektorel.Northwind.Erp.Data.Managers;

namespace Vektorel.Orms.Erp.Data.Repositories
{
    public class CategoryRepository : IConnectionManager
    {
        private ConnectionManager connectionManager;

        public void CreateConnection()
        {
            connectionManager = new ConnectionManager();
        }

        public List<Category> GetCategories()
        {
            var query = "select * from Categories";
            return connectionManager.GetConnection().Query<Category>(query).ToList();
        }
    }
}
