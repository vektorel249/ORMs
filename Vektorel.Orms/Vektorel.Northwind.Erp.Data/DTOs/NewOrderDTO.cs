namespace Vektorel.Northwind.Erp.Data.DTOs;

public class NewOrderDTO
{
    public string CustomerId { get; set; }
    public int EmployeeId { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime RequiredDate { get; set; }
}
