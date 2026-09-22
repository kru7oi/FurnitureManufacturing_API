using System;
using System.Collections.Generic;

namespace FurnitureManufacturing_API.Models;

public partial class CostCalculation
{
    public int CostCalculationId { get; set; }

    public int NomenclatureId { get; set; }

    public decimal Quantity { get; set; }

    public decimal TotalCost { get; set; }

    public DateTime? CalculationDate { get; set; }

    public virtual ICollection<CostCalculationMaterial> CostCalculationMaterials { get; set; } = new List<CostCalculationMaterial>();

    public virtual ICollection<CostCalculationOperation> CostCalculationOperations { get; set; } = new List<CostCalculationOperation>();

    public virtual Nomenclature Nomenclature { get; set; } = null!;
}
