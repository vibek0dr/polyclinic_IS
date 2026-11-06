using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Uslugi
{
    public int IdUslugi { get; set; }

    public string? Zagranpassport { get; set; }

    public string? Visa { get; set; }

    public string? StoimostVisa { get; set; }

    public string? StoimostStrahovki { get; set; }

    public virtual ICollection<Putevki> Putevkis { get; set; } = new List<Putevki>();
}
