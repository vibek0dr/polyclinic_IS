using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class KpRaspisanie
{
    public int KodSlota { get; set; }

    public int KodVracha { get; set; }

    public DateOnly DataPriema { get; set; }

    public TimeOnly VremyaNachala { get; set; }

    public TimeOnly VremyaOkonchaniya { get; set; }

    public int? Status { get; set; }

    public virtual KpVrachi KodVrachaNavigation { get; set; } = null!;

    public virtual KpZapisiNaPriem? KpZapisiNaPriem { get; set; }

    public virtual KpStatusVracha? StatusNavigation { get; set; }
}
