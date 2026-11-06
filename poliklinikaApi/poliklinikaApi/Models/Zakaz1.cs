using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Zakaz1
{
    public int IdZakaz { get; set; }

    public int? Klient { get; set; }

    public string? Status { get; set; }

    public virtual Klient1? KlientNavigation { get; set; }

    public virtual ICollection<Kuryer> Kuryers { get; set; } = new List<Kuryer>();

    public virtual ICollection<Tovarzakaz1> Tovarzakaz1s { get; set; } = new List<Tovarzakaz1>();
}
