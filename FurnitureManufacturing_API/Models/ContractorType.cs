using System;
using System.Collections.Generic;

namespace FurnitureManufacturing_API.Models;

public partial class ContractorType
{
    public int ContractorTypeId { get; set; }

    public string TypeName { get; set; } = null!;

    public virtual ICollection<Contractor> Contractors { get; set; } = new List<Contractor>();
}
