using System;
using System.Collections.Generic;

namespace FurnitureManufacturing_API.Models;

public partial class CustomerOrder
{
    public int CustomerOrderId { get; set; }

    public string OrderNumber { get; set; } = null!;

    public DateOnly OrderDate { get; set; }

    public int ContractorId { get; set; }

    public int ManufacturerId { get; set; }

    public decimal TotalAmount { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual Contractor Contractor { get; set; } = null!;

    public virtual ICollection<CustomerOrderItem> CustomerOrderItems { get; set; } = new List<CustomerOrderItem>();

    public virtual Manufacturer Manufacturer { get; set; } = null!;
}
