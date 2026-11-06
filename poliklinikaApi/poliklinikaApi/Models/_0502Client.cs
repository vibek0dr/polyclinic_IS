using System;
using System.Collections.Generic;

namespace poliklinikaApi.Models;

public partial class _0502Client
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public string? Patronymic { get; set; }

    public DateOnly Birthday { get; set; }

    public DateOnly RegistrationDate { get; set; }

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public int? GenderCode { get; set; }

    public string PhotoPath { get; set; } = null!;

    public string? MainImage { get; set; }

    public virtual _0502Gender? GenderCodeNavigation { get; set; }

    public virtual ICollection<_0502ClientService> _0502ClientServices { get; set; } = new List<_0502ClientService>();

    public virtual ICollection<_0502Tag> Tags { get; set; } = new List<_0502Tag>();
}
