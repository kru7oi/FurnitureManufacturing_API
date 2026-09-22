using System;
using System.Collections.Generic;

namespace FurnitureManufacturing_API.Models;

public partial class SpecificationComponent
{
    public int SpecificationComponentId { get; set; }

    public int SpecificationId { get; set; }

    public int NomenclatureId { get; set; }

    public decimal Quantity { get; set; }

    public virtual Nomenclature Nomenclature { get; set; } = null!;

    public virtual Specification Specification { get; set; } = null!;
}
