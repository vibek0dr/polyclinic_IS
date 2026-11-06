using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class AvtorKnigi
{
    public int IdAvtKnigi { get; set; }

    public int? IdAvtora { get; set; }

    public int GonorarAvtora { get; set; }

    public int PoryadkoviiNomer { get; set; }

    public int? Isbn { get; set; }

    public virtual Avtori? IdAvtoraNavigation { get; set; }

    public virtual Knigi? IsbnNavigation { get; set; }
}
