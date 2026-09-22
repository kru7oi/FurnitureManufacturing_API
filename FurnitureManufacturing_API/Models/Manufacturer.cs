using System;
using System.Collections.Generic;

namespace FurnitureManufacturing_API.Models;

public partial class Manufacturer
{
    public int ManufacturerId { get; set; }

    public string ManufacturerName { get; set; } = null!;

    public virtual ICollection<CustomerOrder> CustomerOrders { get; set; } = new List<CustomerOrder>();

    public virtual ICollection<Specification> Specifications { get; set; } = new List<Specification>();
}
