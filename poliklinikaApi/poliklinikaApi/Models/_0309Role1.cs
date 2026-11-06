using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0309Role1
{
    public int IdRole { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<_0309User1> _0309User1s { get; set; } = new List<_0309User1>();
}
