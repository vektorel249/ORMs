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

        public void Dispose()
        {

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
    }
}
