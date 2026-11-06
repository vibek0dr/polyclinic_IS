using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class KpRezultatyPriema
{
    public int KodRezultata { get; set; }

    public int KodZapisi { get; set; }

    public string? Zhaloby { get; set; }

    public string? Diagnoz { get; set; }

    public string? Naznacheniya { get; set; }

    public string? Rekomendacii { get; set; }

    public virtual KpZapisiNaPriem KodZapisiNavigation { get; set; } = null!;
}
