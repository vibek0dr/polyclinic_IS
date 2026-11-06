using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Gruppa1
{
    public int IdGruppa { get; set; }

    public string? Nazvaniye { get; set; }

    public int? Student { get; set; }

    public virtual Student2? StudentNavigation { get; set; }

    public virtual ICollection<Zanyatie1> Zanyatie1s { get; set; } = new List<Zanyatie1>();
}
