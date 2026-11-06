using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class KnigaAvtor
{
    public int? IdKniga { get; set; }

    public int? IdAvtor { get; set; }

    public virtual Avtor? IdAvtorNavigation { get; set; }

    public virtual Kniga? IdKnigaNavigation { get; set; }
}
