using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class KpStatusVracha
{
    public int KodStatusa { get; set; }

    public string? Nazvanie { get; set; }

    public virtual ICollection<KpRaspisanie> KpRaspisanies { get; set; } = new List<KpRaspisanie>();
}
