using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Role2
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<User2> User2s { get; set; } = new List<User2>();
}
