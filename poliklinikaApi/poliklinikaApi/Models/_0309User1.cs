using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0309User1
{
    public int IdUser { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Role { get; set; }

    public int IsBlocked { get; set; }

    public int? CountFailedLogin { get; set; }

    public virtual _0309Role1 RoleNavigation { get; set; } = null!;
}
