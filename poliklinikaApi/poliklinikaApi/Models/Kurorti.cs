using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Kurorti
{
    public int IdKurorta { get; set; }

    public string? Nazvanie { get; set; }

    public string? Strana { get; set; }

    public string? Raspolojenie { get; set; }

    public string? Kommentarii { get; set; }

    public virtual ICollection<Putevki> Putevkis { get; set; } = new List<Putevki>();
}
