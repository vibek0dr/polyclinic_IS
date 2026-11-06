using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Gruppi
{
    public int IdGruppi { get; set; }

    public string? Fakultet { get; set; }

    public string? Specialnost { get; set; }

    public int? Kurs { get; set; }

    public string? Nomer { get; set; }

    public virtual ICollection<Raspisaniye> Raspisaniyes { get; set; } = new List<Raspisaniye>();
}
