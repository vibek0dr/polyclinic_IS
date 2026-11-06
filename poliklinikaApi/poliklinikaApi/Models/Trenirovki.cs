using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Trenirovki
{
    public int IdTrenirovki { get; set; }

    public string MestoProvedeniyaTrenirovok { get; set; } = null!;

    public string Raspisaniye { get; set; } = null!;

    public string ProdoljitelnostOdnoyTrenirovki { get; set; } = null!;

    public int? NomerZala { get; set; }

    public int IdTrenera { get; set; }

    public virtual Trenera IdTreneraNavigation { get; set; } = null!;
}
