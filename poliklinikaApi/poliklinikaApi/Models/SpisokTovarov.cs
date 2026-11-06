using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class SpisokTovarov
{
    public int IdTovara { get; set; }

    public string? Nazvanie { get; set; }

    public decimal? Cena { get; set; }

    public int KolichestvoVNalichie { get; set; }

    public virtual ICollection<ProdajaTovara> ProdajaTovaras { get; set; } = new List<ProdajaTovara>();
}
