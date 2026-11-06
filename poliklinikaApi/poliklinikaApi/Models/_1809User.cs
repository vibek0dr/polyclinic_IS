using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _1809User
{
    public int IdUser { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int IdZodiak { get; set; }

    public DateOnly DateOfBirth { get; set; }

    public virtual _1809ZodiakSign IdZodiakNavigation { get; set; } = null!;
}
