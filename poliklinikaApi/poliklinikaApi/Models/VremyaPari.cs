using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class VremyaPari
{
    public int NomerPari { get; set; }

    public TimeOnly? Nachalo { get; set; }

    public TimeOnly? Konec { get; set; }

    public virtual ICollection<Raspisaniye> Raspisaniyes { get; set; } = new List<Raspisaniye>();
}
