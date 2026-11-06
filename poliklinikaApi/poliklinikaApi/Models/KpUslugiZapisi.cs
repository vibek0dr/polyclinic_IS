using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class KpUslugiZapisi
{
    public int KodUslugiZapisi { get; set; }

    public int KodUslugi { get; set; }

    public int KodZapisi { get; set; }

    public virtual KpUslugi KodUslugiNavigation { get; set; } = null!;

    public virtual KpZapisiNaPriem KodZapisiNavigation { get; set; } = null!;
}
