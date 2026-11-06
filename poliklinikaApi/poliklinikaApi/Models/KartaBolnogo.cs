using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class KartaBolnogo
{
    public int IdKarti { get; set; }

    public string? Simptomi { get; set; }

    public string? Diagnoz { get; set; }

    public string? Lekarstvo { get; set; }

    public virtual ICollection<Pacient> Pacients { get; set; } = new List<Pacient>();
}
