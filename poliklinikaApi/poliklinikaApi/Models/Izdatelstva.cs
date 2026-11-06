using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Izdatelstva
{
    public int IdIzdatelstva { get; set; }

    public string? Izdatelstvo { get; set; }

    public string? Gorod { get; set; }

    public virtual ICollection<Knigii> Knigiis { get; set; } = new List<Knigii>();
}
