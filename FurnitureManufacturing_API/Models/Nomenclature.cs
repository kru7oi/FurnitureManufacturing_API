using System;
using System.Collections.Generic;

namespace FurnitureManufacturing_API.Models;

public partial class Nomenclature
{
    public int NomenclatureId { get; set; }

    public string NomenclatureCode { get; set; } = null!;

    public string NomenclatureName { get; set; } = null!;

    public int NomenclatureTypeId { get; set; }

    public int UnitId { get; set; }

    public virtual ICollection<CostCalculationMaterial> CostCalculationMaterials { get; set; } = new List<CostCalculationMaterial>();

    public virtual ICollection<CostCalculationOperation> CostCalculationOperations { get; set; } = new List<CostCalculationOperation>();

    public virtual ICollection<CostCalculation> CostCalculations { get; set; } = new List<CostCalculation>();

    public virtual ICollection<CustomerOrderItem> CustomerOrderItems { get; set; } = new List<CustomerOrderItem>();

    public virtual NomenclatureType NomenclatureType { get; set; } = null!;

    public virtual ICollection<Price> Prices { get; set; } = new List<Price>();

    public virtual ICollection<ProductionOrderMaterial> ProductionOrderMaterials { get; set; } = new List<ProductionOrderMaterial>();

    public virtual ICollection<ProductionOrderOperation> ProductionOrderOperations { get; set; } = new List<ProductionOrderOperation>();

    public virtual ICollection<ProductionOrder> ProductionOrders { get; set; } = new List<ProductionOrder>();

    public virtual ICollection<SpecificationComponent> SpecificationComponents { get; set; } = new List<SpecificationComponent>();

    public virtual ICollection<SpecificationOperation> SpecificationOperations { get; set; } = new List<SpecificationOperation>();

    public virtual ICollection<Specification> Specifications { get; set; } = new List<Specification>();

    public virtual Unit Unit { get; set; } = null!;
}
