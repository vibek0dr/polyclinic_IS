using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Vagon
{
    public int IdVagon { get; set; }

    public string? TipVagona { get; set; }

    public int? Poezd { get; set; }

    public virtual ICollection<Bilet> Bilets { get; set; } = new List<Bilet>();

    public virtual Poezd? PoezdNavigation { get; set; }
}
