using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Kabinet
{
    public int NomerKabineta { get; set; }

    public string? Naznacheniya { get; set; }

    public virtual ICollection<Priem> Priems { get; set; } = new List<Priem>();
}
