using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class OblastZnaniy
{
    public int IdOblastZnaniy { get; set; }

    public string? Nazvanie { get; set; }

    public virtual ICollection<Kniga> Knigas { get; set; } = new List<Kniga>();
}
