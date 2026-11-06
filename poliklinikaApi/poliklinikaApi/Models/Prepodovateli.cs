using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Prepodovateli
{
    public int IdPrepodovatelya { get; set; }

    public string? Familiya { get; set; }

    public string? Imya { get; set; }

    public string? Otchestvo { get; set; }

    public virtual ICollection<Raspisaniye> Raspisaniyes { get; set; } = new List<Raspisaniye>();
}
