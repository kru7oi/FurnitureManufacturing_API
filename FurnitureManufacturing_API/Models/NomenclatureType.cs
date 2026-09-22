using System;
using System.Collections.Generic;

namespace FurnitureManufacturing_API.Models;

public partial class NomenclatureType
{
    public int NomenclatureTypeId { get; set; }

    public string TypeName { get; set; } = null!;

    public virtual ICollection<Nomenclature> Nomenclatures { get; set; } = new List<Nomenclature>();
}
