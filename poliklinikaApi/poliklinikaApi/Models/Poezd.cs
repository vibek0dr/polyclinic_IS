using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Poezd
{
    public int IdPoezda { get; set; }

    public int? Marshrut { get; set; }

    public DateOnly? DataOtpravleniya { get; set; }

    public virtual Marshrut? MarshrutNavigation { get; set; }

    public virtual ICollection<Vagon> Vagons { get; set; } = new List<Vagon>();
}
