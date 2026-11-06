using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Otdeleniye
{
    public int IdOtdeleniya { get; set; }

    public string? Nazvanie { get; set; }

    public string? Zaveduchaya { get; set; }

    public virtual ICollection<Gruppaa> Gruppaas { get; set; } = new List<Gruppaa>();
}
