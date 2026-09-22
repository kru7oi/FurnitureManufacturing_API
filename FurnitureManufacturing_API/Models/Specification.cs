using System;
using System.Collections.Generic;

namespace FurnitureManufacturing_API.Models;

public partial class Specification
{
    public int SpecificationId { get; set; }

    public int NomenclatureId { get; set; }

    public int ManufacturerId { get; set; }

    public string SpecificationNumber { get; set; } = null!;

    public string? ApprovedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual Manufacturer Manufacturer { get; set; } = null!;

    public virtual Nomenclature Nomenclature { get; set; } = null!;

    public virtual ICollection<SpecificationComponent> SpecificationComponents { get; set; } = new List<SpecificationComponent>();

    public virtual ICollection<SpecificationOperation> SpecificationOperations { get; set; } = new List<SpecificationOperation>();
}
