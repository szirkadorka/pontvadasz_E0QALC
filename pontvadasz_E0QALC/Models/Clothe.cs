using System;
using System.Collections.Generic;

namespace pontvadasz_E0QALC.Models;

public partial class Clothe
{
    public int ClothesId { get; set; }

    public string? ClothesName { get; set; }

    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public virtual ICollection<OutfitList> OutfitLists { get; } = new List<OutfitList>();
}
