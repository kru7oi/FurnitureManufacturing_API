using System;
using System.Collections.Generic;

namespace FurnitureManufacturing_API.Models;

public partial class Contractor
{
    public int ContractorId { get; set; }

    public string ContractorCode { get; set; } = null!;

    public string ContractorName { get; set; } = null!;

    public string? Inn { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual ICollection<CustomerOrder> CustomerOrders { get; set; } = new List<CustomerOrder>();

    public virtual ICollection<ContractorType> ContractorTypes { get; set; } = new List<ContractorType>();
}
