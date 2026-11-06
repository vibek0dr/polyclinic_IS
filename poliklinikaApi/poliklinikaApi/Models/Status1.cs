using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Status1
{
    public int IdStatuza { get; set; }

    public string? Nazvanie { get; set; }

    public virtual ICollection<Zakaz4> Zakaz4s { get; set; } = new List<Zakaz4>();
}
