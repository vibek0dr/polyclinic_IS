using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Klassifikaciya
{
    public int IdKlassifikacii { get; set; }

    public string Zvanie { get; set; } = null!;

    public virtual ICollection<Sportsmeni> Sportsmenis { get; set; } = new List<Sportsmeni>();
}
