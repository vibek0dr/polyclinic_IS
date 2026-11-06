using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class TrudovayaKnijka
{
    public int IdTrudovoyKnijki { get; set; }

    public int? Sotrudnik { get; set; }

    public string? Staj { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<Archiv> Archivs { get; set; } = new List<Archiv>();

    public virtual Sotrudnik? SotrudnikNavigation { get; set; }
}
