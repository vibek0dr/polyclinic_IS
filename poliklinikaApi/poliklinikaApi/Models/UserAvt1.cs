using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class UserAvt1
{
    public int IdUser { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Patronymic { get; set; }

    public string? Passport { get; set; }

    public string? Phone { get; set; }
}
