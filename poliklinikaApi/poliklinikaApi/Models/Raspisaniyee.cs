using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Raspisaniyee
{
    public int NomerZapisi { get; set; }

    public DateOnly? Data { get; set; }

    public TimeOnly? VremyaNachala { get; set; }

    public TimeOnly? VremyaOkonchaniya { get; set; }

    public int? IdSotrudnika { get; set; }

    public int? IdTrenirovki { get; set; }

    public int? IdUslugi { get; set; }

    public virtual SpisokSotrudnikov? IdSotrudnikaNavigation { get; set; }

    public virtual SpisokUslug? IdUslugiNavigation { get; set; }

    public virtual ICollection<UshetPosesheniy> UshetPosesheniys { get; set; } = new List<UshetPosesheniy>();
}
