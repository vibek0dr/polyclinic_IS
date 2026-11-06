using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class Contact
{
    public int IdContact { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? Patronymic { get; set; }

    public DateOnly DateOfBirth { get; set; }

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;
}
