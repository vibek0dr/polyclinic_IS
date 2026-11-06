using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Marshrut
{
    public int IdMarshrut { get; set; }

    public string? PunktOtpravleniya { get; set; }

    public string? PunktNaznacheniya { get; set; }

    public virtual ICollection<Poezd> Poezds { get; set; } = new List<Poezd>();
}
