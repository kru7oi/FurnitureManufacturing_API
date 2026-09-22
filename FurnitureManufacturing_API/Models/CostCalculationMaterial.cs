using System;
using System.Collections.Generic;

namespace FurnitureManufacturing_API.Models;

public partial class CostCalculationMaterial
{
    public int CostCalculationMaterialId { get; set; }

    public int CostCalculationId { get; set; }

    public int NomenclatureId { get; set; }

    public decimal Quantity { get; set; }

    public decimal Price { get; set; }

    public decimal TotalAmount { get; set; }

    public virtual CostCalculation CostCalculation { get; set; } = null!;

    public virtual Nomenclature Nomenclature { get; set; } = null!;
}
