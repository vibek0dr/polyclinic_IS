using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Avtorii
{
    public int IdAvtora { get; set; }

    public string? Familiya { get; set; }

    public string? Imya { get; set; }

    public string? Primechaniya { get; set; }

    public virtual ICollection<AvtorKnigii> AvtorKnigiis { get; set; } = new List<AvtorKnigii>();
}
