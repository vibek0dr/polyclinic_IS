using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class KpStatusZapisi
{
    public int KodStatusa { get; set; }

    public string Nazvanie { get; set; } = null!;

    public virtual ICollection<KpZapisiNaPriem> KpZapisiNaPriems { get; set; } = new List<KpZapisiNaPriem>();
}
