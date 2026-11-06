using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class RoleCafe
{
    public int IdRole { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<UserCafe> UserCaves { get; set; } = new List<UserCafe>();
}
