using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Visit
{
    public int VisitId { get; set; }

    public int ClientId { get; set; }

    public DateTime EntryTime { get; set; }

    public DateTime? ExitTime { get; set; }

    public string VisitType { get; set; } = null!;

    public virtual Client2 Client { get; set; } = null!;
}
