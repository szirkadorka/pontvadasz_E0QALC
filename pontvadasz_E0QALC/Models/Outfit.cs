using System;
using System.Collections.Generic;

namespace pontvadasz_E0QALC.Models;

public partial class Outfit
{
    public int OutfitId { get; set; }

    public string? OutfitName { get; set; }

    public virtual ICollection<OutfitList> OutfitLists { get; } = new List<OutfitList>();
}
