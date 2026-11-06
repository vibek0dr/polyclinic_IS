using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Putevki
{
    public int IdPutevki { get; set; }

    public int? IdKurorta { get; set; }

    public int? IdNomera { get; set; }

    public int? IdUslugi { get; set; }

    public DateOnly? DataNachala { get; set; }

    public string? Prodoljitelnost { get; set; }

    public string? StoimostVsego { get; set; }

    public virtual Kurorti? IdKurortaNavigation { get; set; }

    public virtual Nomer? IdNomeraNavigation { get; set; }

    public virtual Uslugi? IdUslugiNavigation { get; set; }

    public virtual ICollection<Klienti> Klientis { get; set; } = new List<Klienti>();
}
