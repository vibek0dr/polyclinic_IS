using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Up03Model
{
    public int Kod { get; set; }

    public int KodMarki { get; set; }

    public string Nazvanie { get; set; } = null!;

    public string? TipKuzova { get; set; }

    public virtual Up03Marka KodMarkiNavigation { get; set; } = null!;

    public virtual ICollection<Up03Avtomobil> Up03Avtomobils { get; set; } = new List<Up03Avtomobil>();
}
