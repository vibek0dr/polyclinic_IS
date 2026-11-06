using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0309User
{
    public int IdUser { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Patronymic { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int Status { get; set; }

    public DateOnly LastLoginDate { get; set; }

    public int IdRole { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual _0309Role IdRoleNavigation { get; set; } = null!;

    public virtual _0309Status StatusNavigation { get; set; } = null!;
}
