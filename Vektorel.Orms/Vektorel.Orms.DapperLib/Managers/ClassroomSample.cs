using Dapper;
using Microsoft.Data.SqlClient;
using Vektorel.Orms.Data.Entities;

namespace Vektorel.Orms.DapperLib.Managers
{
    //Burada Almanya'daki tedarikçilerin ekrana yazılacağı bir işlemi Dapper ile çözeceğiz
    public class ClassroomSample
    {
        public List<Supplier> GetSuppliersInGermany()
        {
            using var connection = new SqlConnection("Server=192.168.254.198;Database=Northwind;User Id=va249;Password=123;TrustServerCertificate=true;");
            connection.Open();
            var query = "select SupplierID, CompanyName, ContactName, City, Phone from Suppliers where Country = 'Germany'";
            return connection.Query<Supplier>(query).ToList();
        }
    }
}
