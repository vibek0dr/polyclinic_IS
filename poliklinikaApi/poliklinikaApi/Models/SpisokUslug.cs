using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class SpisokUslug
{
    public int IdUslugi { get; set; }

    public string Naimenovaniye { get; set; } = null!;

    public virtual ICollection<Raspisaniyee> Raspisaniyees { get; set; } = new List<Raspisaniyee>();
}
