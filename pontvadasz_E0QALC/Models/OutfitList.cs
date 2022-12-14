using System;
using System.Collections.Generic;

namespace pontvadasz_E0QALC.Models;

public partial class OutfitList
{
    public int OutfitListSk { get; set; }

    public int? OutfitFk { get; set; }

    public int? ClothesFk { get; set; }

    public virtual Clothe? ClothesFkNavigation { get; set; }

    public virtual Outfit? OutfitFkNavigation { get; set; }
}
