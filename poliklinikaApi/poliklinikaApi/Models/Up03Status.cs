using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Up03Status
{
    public int Kod { get; set; }

    public string Nazvanie { get; set; } = null!;

    public string? Opisanie { get; set; }

    public virtual ICollection<Up03Avtomobil> Up03Avtomobils { get; set; } = new List<Up03Avtomobil>();
}
