using System;
using System.Collections.Generic;

namespace FurnitureManufacturing_API.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int RoleId { get; set; }

    public bool IsBlocked { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual ICollection<Note> Notes { get; set; } = new List<Note>();

    public virtual ICollection<ProductionOrder> ProductionOrders { get; set; } = new List<ProductionOrder>();

    public virtual Role Role { get; set; } = null!;
}
