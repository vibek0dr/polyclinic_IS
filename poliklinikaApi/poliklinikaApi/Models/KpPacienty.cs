using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class KpPacienty
{
    public int KodPacienta { get; set; }

    public string Familiya { get; set; } = null!;

    public string Imya { get; set; } = null!;

    public string Otchestvo { get; set; } = null!;

    public DateOnly DataRozhdeniya { get; set; }

    public string Pol { get; set; } = null!;

    public string NomerPolisa { get; set; } = null!;

    public string? Adres { get; set; }

    public string? Telefon { get; set; }

    public virtual ICollection<KpZapisiNaPriem> KpZapisiNaPriems { get; set; } = new List<KpZapisiNaPriem>();
}
