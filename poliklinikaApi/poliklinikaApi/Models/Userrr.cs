using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Userrr
{
    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string RoleId { get; set; } = null!;

    public virtual Rolee Role { get; set; } = null!;
}
