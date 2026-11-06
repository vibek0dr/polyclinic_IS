using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class User1
{
    public int Id { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public int? IdRole { get; set; }

    public virtual Role1? IdRoleNavigation { get; set; }
}
