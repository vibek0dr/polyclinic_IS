using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class TipDocumentum
{
    public int IdTipDocumenta { get; set; }

    public string? Nazvanie { get; set; }

    public virtual ICollection<Passajir> Passajirs { get; set; } = new List<Passajir>();
}
