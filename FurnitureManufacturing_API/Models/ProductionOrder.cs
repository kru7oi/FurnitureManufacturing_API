using System;
using System.Collections.Generic;

namespace FurnitureManufacturing_API.Models;

public partial class ProductionOrder
{
    public int ProductionOrderId { get; set; }

    public string OrderNumber { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public int DepartmentId { get; set; }

    public int NomenclatureId { get; set; }

    public decimal Quantity { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ExecutorId { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual User? Executor { get; set; }

    public virtual Nomenclature Nomenclature { get; set; } = null!;

    public virtual ICollection<ProductionOrderMaterial> ProductionOrderMaterials { get; set; } = new List<ProductionOrderMaterial>();

    public virtual ICollection<ProductionOrderOperation> ProductionOrderOperations { get; set; } = new List<ProductionOrderOperation>();
}
