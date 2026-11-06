using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Mdk0502StRole
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<Mdk0502StUser> Mdk0502StUsers { get; set; } = new List<Mdk0502StUser>();
}
