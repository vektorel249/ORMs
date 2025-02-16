using System.ComponentModel;

namespace Vektorel.Northwind.Erp.Data.DTOs;

public class OrderListDTO
{
    [DisplayName("Sipariş No")]
    public int OrderId { get; set; }
    [DisplayName("Müşteri")]
    public string Customer { get; set; }
    [DisplayName("Sipariş tarihi")]
    public DateTime OrderDate { get; set; }
    [DisplayName("Tutar")]
    public decimal Total { get; set; }
}