using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Zanyatiya
{
    public int IdZanyatiya { get; set; }

    public string? TipZanyatiya { get; set; }

    public virtual ICollection<Raspisaniye> Raspisaniyes { get; set; } = new List<Raspisaniye>();
}
