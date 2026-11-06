using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Razdeli
{
    public int IdRazdela { get; set; }

    public string? Razdel { get; set; }

    public virtual ICollection<Knigii> Knigiis { get; set; } = new List<Knigii>();
}
