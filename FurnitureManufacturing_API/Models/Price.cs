using System;
using System.Collections.Generic;

namespace FurnitureManufacturing_API.Models;

public partial class Price
{
    public int PriceId { get; set; }

    public int NomenclatureId { get; set; }

    public decimal Price1 { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public virtual Nomenclature Nomenclature { get; set; } = null!;
}
