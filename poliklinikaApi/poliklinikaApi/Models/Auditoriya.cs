using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Auditoriya
{
    public int IdAuditorii { get; set; }

    public string? Zdanie { get; set; }

    public int? Etaj { get; set; }

    public string? Nomer { get; set; }

    public virtual ICollection<Raspisaniye> Raspisaniyes { get; set; } = new List<Raspisaniye>();
}
