using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vektorel.Northwind.Erp.Data.DTOs;
using Vektorel.Northwind.Erp.Data.Managers;

namespace Vektorel.Northwind.Erp.Data.Repositories
{
    public class OrderRepository : IConnectionManager
    {
        private ConnectionManager connectionManager;

        public OrderRepository()
        {
            CreateConnection();
        }
        public void CreateConnection()
        {
            connectionManager = new ConnectionManager();
        }

        public int CreateOrder(NewOrderDTO order)
        {
            var query = @"insert into Orders (CustomerID, EmployeeID, OrderDate, RequiredDate)
                          values (@CustomerId, @EmployeeId, @OrderDate, @RequiredDate);

                          select scope_identity();"; // eklnen kaydı identity değerini de getir

            return connectionManager.GetConnection().ExecuteScalar<int>(query, order);
        }

        public void Dispose()
        {
            if (connectionManager.IsConnected)
            {
                connectionManager.Kill();
            }
        }

        public List<OrderDetailDTO> GetDetails(int orderId)
        {
            var query = $@"select 
                           	  p.ProductName as Product, 
                           	  od.Quantity as Amount, 
                           	  od.UnitPrice as Price
                           from [Order Details] od
                           inner join Products p on od.ProductID = p.ProductID
                           where od.OrderID = {orderId}
                           order by Product";
            return connectionManager.GetConnection().Query<OrderDetailDTO>(query).ToList();
        }

        public List<EmployeePerformanceDTO> GetEmployeePerformance()
        {
            var query = @"select 
	                          concat(e.FirstName, ' ', e.LastName) as Employee, 
	                          sum(od.UnitPrice * od.Quantity) as Total
                          from [Order Details] od
                          inner join Orders o on od.OrderID = o.OrderID
                          inner join Employees e on o.EmployeeID = e.EmployeeID
                          group by concat(e.FirstName, ' ', e.LastName)";

            return connectionManager.GetConnection().Query<EmployeePerformanceDTO>(query).ToList();
        }

        public List<OrderListDTO> GetLastOrders(int? orderId = null)
        {
            var builder = new StringBuilder(); // BUilder pattern
            var query = @"select top 10 
	                          o.OrderID as OrderId,
	                          c.CompanyName as Customer,
	                          o.OrderDate as OrderDate,
	                          SUM(od.Quantity * od.UnitPrice) as Total
                          from Orders o
                          inner join Customers c on o.CustomerID = c.CustomerID
                          inner join [Order Details] od on o.OrderID = od.OrderID";
            builder.AppendLine(query);

            if (orderId.HasValue)
            {
                builder.AppendLine($"where o.OrderID = {orderId.Value}");
            }
            builder.AppendLine("group by o.OrderID, c.CompanyName, o.OrderDate");
            if (!orderId.HasValue)
            {
                builder.AppendLine("order by o.OrderDate desc, o.OrderID");
            }

            return connectionManager.GetConnection().Query<OrderListDTO>(builder.ToString()).ToList();
        }

        public OrderMetadataDTO GetMetadata(int orderId)
        {
            var query = $@"select 
	                             c.CompanyName as Customer, 
	                             c.Phone, 
	                             o.OrderDate, 
	                             o.RequiredDate, 
	                             CONCAT(e.FirstName, ' ', e.LastName) as Employee from Orders o
                           inner join Customers c on o.CustomerID = c.CustomerID
                           inner join Employees e on o.EmployeeID = e.EmployeeID
                           where o.OrderID = {orderId}";

            return connectionManager.GetConnection().QueryFirst<OrderMetadataDTO>(query);
        }
    }
}
