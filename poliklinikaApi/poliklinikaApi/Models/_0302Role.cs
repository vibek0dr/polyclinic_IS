using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0302Role
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<_0302User> _0302Users { get; set; } = new List<_0302User>();
}
