using System;
using System.Collections.Generic;

namespace FurnitureManufacturing_API.Models;

public partial class SpecificationOperation
{
    public int SpecificationOperationId { get; set; }

    public int SpecificationId { get; set; }

    public int NomenclatureId { get; set; }

    public decimal TimeNorm { get; set; }

    public int Quantity { get; set; }

    public virtual Nomenclature Nomenclature { get; set; } = null!;

    public virtual Specification Specification { get; set; } = null!;
}
