using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Raspisaniye
{
    public int IdZanyatiya { get; set; }

    public DateOnly? Data { get; set; }

    public int? NomerPari { get; set; }

    public int? Gruppa { get; set; }

    public int? TipZanyatiya { get; set; }

    public int? Prepodovatel { get; set; }

    public int? Auditoriya { get; set; }

    public virtual Auditoriya? AuditoriyaNavigation { get; set; }

    public virtual Gruppi? GruppaNavigation { get; set; }

    public virtual VremyaPari? NomerPariNavigation { get; set; }

    public virtual Prepodovateli? PrepodovatelNavigation { get; set; }

    public virtual Zanyatiya? TipZanyatiyaNavigation { get; set; }
}
