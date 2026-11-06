using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class KpZapisiNaPriem
{
    public int KodZapisi { get; set; }

    public int KodPacienta { get; set; }

    public int KodSlota { get; set; }

    public DateTime DataSozdaniya { get; set; }

    public int StatusZapisi { get; set; }

    public virtual KpPacienty KodPacientaNavigation { get; set; } = null!;

    public virtual KpRaspisanie KodSlotaNavigation { get; set; } = null!;

    public virtual KpRezultatyPriema? KpRezultatyPriema { get; set; }

    public virtual ICollection<KpUslugiZapisi> KpUslugiZapisis { get; set; } = new List<KpUslugiZapisi>();

    public virtual KpStatusZapisi StatusZapisiNavigation { get; set; } = null!;
}
