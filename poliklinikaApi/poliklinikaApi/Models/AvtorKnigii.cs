using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class AvtorKnigii
{
    public int IdAvtoraKnigi { get; set; }

    public int? IdKnigi { get; set; }

    public int? IdAvtora { get; set; }

    public virtual Avtorii? IdAvtoraNavigation { get; set; }

    public virtual Knigii? IdKnigiNavigation { get; set; }
}
