namespace Vektorel.Northwind.Erp.Data.DTOs;

public class NewProductDTO
{
    public string Name { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public int SupplierId { get; set; }
}