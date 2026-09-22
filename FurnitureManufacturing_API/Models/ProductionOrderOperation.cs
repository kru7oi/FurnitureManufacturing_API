using System;
using System.Collections.Generic;

namespace FurnitureManufacturing_API.Models;

public partial class ProductionOrderOperation
{
    public int ProductionOrderOperationId { get; set; }

    public int ProductionOrderId { get; set; }

    public int NomenclatureId { get; set; }

    public decimal Quantity { get; set; }

    public virtual Nomenclature Nomenclature { get; set; } = null!;

    public virtual ProductionOrder ProductionOrder { get; set; } = null!;
}
