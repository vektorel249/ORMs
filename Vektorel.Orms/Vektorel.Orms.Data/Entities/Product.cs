namespace Vektorel.Orms.Data.Entities;

public sealed class Product
{
    public int ProductID { get; set; }
    public string? ProductName { get; set; }
    public int UnitsInStock { get; set; }
    public decimal UnitPrice { get; set; }
}