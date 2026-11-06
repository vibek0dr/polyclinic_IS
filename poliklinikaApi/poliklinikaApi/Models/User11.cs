using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class User11
{
    public int Id { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public int? IdRole { get; set; }

    public string? Familiya { get; set; }

    public string? Imya { get; set; }

    public string? Otchestvo { get; set; }

    public virtual Role11? IdRoleNavigation { get; set; }
}
