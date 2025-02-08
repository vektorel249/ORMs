using System.Data.Common;
using Vektorel.Orms.Data.Entities;

namespace Vektorel.Orms.Data.Connection;

public interface IDataConnection
{
    string? ConnectionString { get; set; }
    DbConnection Connect();
    List<Category> GetCategories();
    IEnumerable<Product> GetProducts();
}
