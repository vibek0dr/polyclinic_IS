using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Zakaz2
{
    public int IdZakaz { get; set; }

    public int? Client { get; set; }

    public string? Status { get; set; }

    public DateOnly? DataZakaza { get; set; }

    public virtual Client1? ClientNavigation { get; set; }

    public virtual ICollection<Kuryer1> Kuryer1s { get; set; } = new List<Kuryer1>();

    public virtual ICollection<TovarZakaz11> TovarZakaz11s { get; set; } = new List<TovarZakaz11>();
}
