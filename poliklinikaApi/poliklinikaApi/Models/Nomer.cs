using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Nomer
{
    public int IdNomera { get; set; }

    public int? KolvoMest { get; set; }

    public string? TipNomera { get; set; }

    public string? StoimostSutki { get; set; }

    public string? AdressGostinici { get; set; }

    public string? Haracteristika { get; set; }

    public virtual ICollection<Putevki> Putevkis { get; set; } = new List<Putevki>();
}
