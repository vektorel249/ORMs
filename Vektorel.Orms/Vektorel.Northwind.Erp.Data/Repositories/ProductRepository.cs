using Dapper;
using Microsoft.Data.SqlClient;
using Vektorel.Northwind.Erp.Data.DTOs;
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

        public List<Product> GetProducts(int offset)
        {
            var pageSize = 10;
            offset = offset * pageSize;
            var query = @$"select ProductID, ProductName, UnitPrice, UnitsInStock 
                          from Products
                          order by ProductName
                          offset {offset} rows
                          fetch next {pageSize} rows only";
            return connectionManager.GetConnection().Query<Product>(query).ToList();
        }

        public int GetProductCount()
        {
            return connectionManager.GetConnection().QueryFirst<int>("select count(0) from products");
        }

        public void Save(NewProductDTO product)
        {
            var query = @"insert into Products (ProductName, UnitPrice, UnitsInStock, CategoryID, SupplierID)
                          values (@Name, @Price, @Stock, @CategoryId, @SupplierId)";
            connectionManager.GetConnection().Execute(query, product);
        }

        public void Dispose()
        {
            if (connectionManager.IsConnected)
            {
                connectionManager.Kill();
            }
        }

        public List<Option> GetProductsAsOptions()
        {
            var query = "select ProductID as Code, ProductName as Name from Products order by Name";
            return connectionManager.GetConnection().Query<Option>(query).ToList();
        }
    }
}


// YAGNI : You Aren't Gonna Need It
// KISS  : Keep It Simple & Stupid
// SOLID : 