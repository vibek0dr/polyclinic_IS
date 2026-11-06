using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0309Role
{
    public int IdRole { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<_0309User> _0309Users { get; set; } = new List<_0309User>();
}
