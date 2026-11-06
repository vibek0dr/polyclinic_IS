using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Kind
{
    public int IdKind { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Jewel> Jewels { get; set; } = new List<Jewel>();
}
