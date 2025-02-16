using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.Northwind.Erp.Data.DTOs;

public class OrderMetadataDTO
{
    public string Customer { get; set; }
    public string Employee { get; set; }
    public string Phone { get; set; }
    public DateTime OrderDate { get; set; } 
    public DateTime RequiredDate { get; set; }
}
