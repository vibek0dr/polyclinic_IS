using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Ekzempkyar
{
    public int IdEkzemplyara { get; set; }

    public int? InventarniyNomer { get; set; }

    public int? IdKnigi { get; set; }

    public string? Nalishie { get; set; }

    public virtual ICollection<ChitatelskiyBilet> ChitatelskiyBilets { get; set; } = new List<ChitatelskiyBilet>();
}
