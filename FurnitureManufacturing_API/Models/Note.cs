using System;
using System.Collections.Generic;

namespace FurnitureManufacturing_API.Models;

public partial class Note
{
    public int NoteId { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public int UserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual User User { get; set; } = null!;
}
