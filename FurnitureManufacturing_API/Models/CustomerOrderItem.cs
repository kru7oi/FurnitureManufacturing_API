using System;
using System.Collections.Generic;

namespace FurnitureManufacturing_API.Models;

public partial class CustomerOrderItem
{
    public int CustomerOrderItemId { get; set; }

    public int CustomerOrderId { get; set; }

    public int NomenclatureId { get; set; }

    public decimal Quantity { get; set; }

    public decimal Price { get; set; }

    public decimal Discount { get; set; }

    public decimal TotalAmount { get; set; }

    public virtual CustomerOrder CustomerOrder { get; set; } = null!;

    public virtual Nomenclature Nomenclature { get; set; } = null!;
}
